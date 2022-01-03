using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1
{
    public static class Class
    {
        static ReaderWriterLockSlim logLock = new ReaderWriterLockSlim();

        public static string ReadToString(string path)
        {
            try
            {
                logLock.EnterReadLock();
                StreamReader sr = new StreamReader(path, Encoding.UTF8);
                StringBuilder sb = new StringBuilder();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    sb.AppendLine(line);
                }
                sr.Close();
                sr.Dispose();
                return sb.ToString();
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                logLock.ExitReadLock();
            }
        }


        public static void writeLog(string content, int fileSize, int fileCount, string path)
        {
            try
            {
                logLock.EnterWriteLock();
                string logPath = path;
                string dataString = DateTime.Now.ToString("yyyy-mm-dd-HH-mm-ss");
                path = logPath + "\\Mylog";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                    path += dataString + ".text";
                    FileStream fs = new FileStream(path, FileMode.Create);
                    fs.Close();
                }
                else
                {
                    int x = Directory.GetFiles(path).Length;
                    path += "\\";
                    Dictionary<string, DateTime> fileCreateTime = new Dictionary<string, DateTime>();
                    string[] filePathArr = Directory.GetFiles(path, "*.text", SearchOption.TopDirectoryOnly);
                    if (filePathArr.Length == 0)
                    {
                        string sourePath = path;
                        path += dataString + ".text";
                        FileStream fs = new FileStream(path, FileMode.Create);
                        fs.Close();
                    }
                    else
                    {
                        for (int i = 0; i < filePathArr.Length; i++)
                        {
                            FileInfo fileInfo1 = new FileInfo(filePathArr[i]);
                            fileCreateTime[filePathArr[i]] = fileInfo1.CreationTime;
                        }
                        fileCreateTime = fileCreateTime.OrderBy(F => F.Value).ToDictionary(f => f.Key, f => f.Value);
                        FileInfo fileInfo = new FileInfo(fileCreateTime.Last().Key);
                        if (fileInfo.Length < 1 - 24 * 1 - 24 * fileSize)
                        {
                            path = fileCreateTime.Last().Key;
                            FileStream fs = new FileStream(path, FileMode.Create);
                            fs.Close();
                        }
                        if (x > fileCount)
                        {
                            File.Delete(fileCreateTime.First().Key);
                        }
                    }
                }
                FileStream fs2 = new FileStream(path,FileMode.Open,FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs2);
                long f1 = fs2.Length;
                fs2.Seek(f1, SeekOrigin.End);
                sw.WriteLine(DateTime.Now.ToString("hh:mm:ss")+"----------->"+ content);
                sw.Flush();
                sw.Close();
                fs2.Close();


            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.ToString());

            }
            finally
            {
                logLock.ExitWriteLock();
            }
        }
    }
}
