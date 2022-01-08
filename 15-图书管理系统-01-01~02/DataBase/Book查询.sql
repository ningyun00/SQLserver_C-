select [Uid],Uname,Upwd from [User] where Uname = 'ning';
insert into [User] values('ning','123456');
insert into [User] values('ying','0000');
insert into [User] values('yun','111111');
select * from [Administrator] where Aname = 'ning';
select * from [Administrator] where Akeys = 'QWERTYUIOPAS';
insert into [Administrator] values('ning','1111','QWERTYUIOPAS');
insert into [Administrator] values('yun','1111','QWERTYUIOPAS');
insert into [Administrator] values('ying','1111','QWERTYUIOPAS');
Truncate table [Administrator];
delete from [Administrator];
insert into [Administrator] values('ying','0000','');
insert into [Administrator] values('yun','1111','');
delete from [Administrator] where AID =5;
select * from [BookManage] where bid like '%1%';/*书籍*/
select * from [BookManage] where Bid = 1;
insert into [BookManage] values('幻灵梦寜','寜','起点',1,10);
insert into [BookManage] values('abc','寜','起点',2,11);
select * from Class;
insert into Class values(1,'玄幻类');
insert into Class values(2,'学习类');
insert into Class values(3,'烹饪类');
insert into Class values(4,'科幻类');
insert into Class values(5,'热血类');
Truncate table Class;
update [User] set Upwd = '123' where Uname = 'ning' and Upwd = '12345';
update [Administrator] set Akeys = 'AAAAAAAAAAAA' where AID = 5;
select Bid,Bname,Bauthor,bpress,ctype,Binventory from [BookManage] inner join Class  on [BookManage].Btypeid = class.btypeid;
select * from [BookManage];
update [BookManage] set Bname = '小熊' , Bauthor = '寜',Bpress = '起点',Btypeid = 1,Binventory=1 where Bid = 3;
delete from [BookManage] where Bid =5;
select * from BooksBorrow  where Bid = 2;
insert into BooksBorrow values('幻灵梦寜','寜','女',15,110119120,'银河系，太阳系，地月系，地球，亚洲，中国，湖南，长沙',GETDATE(),'未归还','无备注');
update BooksBorrow set BbookName='{0}' ,Bname ='{1}' ,Bsex ='{2}' ,Bage =1 ,Bphone =2 ,Baddress ='{5}' ,Btime ='{6}' ,BreturnTime ='{7}' ,Bremarks ='{8}' where Bid = 2;
update BooksBorrow set BreturnTime= GETDATE(),Bremarks='已归还' where Bid = 5;
select * from BooksBorrow  where Bremarks like '%已归还%';
Truncate table BooksBorrow;
delete from BooksBorrow ;
select * from [User];
select * from [User] where [Uname] = 'ning';
select * from MyBookrack;
insert into MyBookrack values('大王饶命','肘子');
select * from MyBookshelfKeeper;
insert into MyBookshelfKeeper values('大王饶命','肘子');
insert into MyBookshelfKeeper values('{0}','{1}')


