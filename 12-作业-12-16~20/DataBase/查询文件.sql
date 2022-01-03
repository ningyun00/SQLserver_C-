
select * from T_User where UserName= 'ning'and ID=1;
select * from T_User;
select * from T_Staff;
select * from T_Class where Cname like '%部%';
select SID,Scard,Sname,Ssex,Sage,Saddress,Swages,Cname,Cremarks from T_Staff inner join T_Class  on T_Class.CID = T_Staff.SclassID where Cname like '%部%';
select * from T_Class;
select SID,Scard,Sname,Ssex,Sage,Saddress,Swages,Cname,Cremarks from T_Staff inner join T_Class  on T_Class.CID = T_Staff.SclassID where SID = 2;
insert  into T_Staff values('yun','云','女',12,'阿斯顿飞过',2,4000);
update T_Staff set Scard = '001',Sname = '樱',Ssex = '女',Sage = 13,Saddress='傲娇少女此举将可能',SclassID='2',Swages=400 where Scard = '001';
delete from T_Staff  where SID = 3;
delete from T_Class  where CID = 2;
insert  into T_Class values('数码部','啊吧啊吧');
update T_Class set Cname = '',Cremarks='' where CID = '';
