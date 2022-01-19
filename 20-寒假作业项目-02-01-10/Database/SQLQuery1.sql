select * from EverySingle02;
/*³´²Ë*/
insert into EverySingle02 values('Çå³´°×²Ë',1,10.0,10.0,'');
insert into EverySingle02 values('½´ÓÍ°×²Ë',1,9.0,9.0,'');
insert into EverySingle02 values('Ë®Öó°×²Ë',1,5.0,5.0,'');
insert into EverySingle02 values('°×²Ë',1,2.0,2.0,'');
/*Àä²Ë*/
insert into EverySingle02 values('º«¹úÅİ²Ë',2,10.0,10.0,'');
insert into EverySingle02 values('Ãæ½´»Æ¹Ï',2,10.0,10.0,'');
insert into EverySingle02 values('½´ÂÜ²·',2,12.0,12.0,'');
insert into EverySingle02 values('ĞÄÌ«Èí',2,12.0,12.0,'');
insert into EverySingle02 values('°èË¿¹Ï¼â',2,12.0,12.0,'');
insert into EverySingle02 values('¶ç½·Æ¤µ°',2,16.0,16.0,'');
insert into EverySingle02 values('Åİ½·Ä¾¶ú',2,16.0,16.0,'');
insert into EverySingle02 values('´ó·áÊÕ',2,16.0,16.0,'');
insert into EverySingle02 values('ÎåÏãÅ£Èâ',2,38.0,38.0,'');
insert into EverySingle02 values('°×ÇĞÑòÈâ',2,58.0,58.0,'');
/*º£ÏÊ*/
insert into EverySingle02 values('°ÄÖŞÁúÏº',3,128.9,128.9,'Ê±¼Û');

insert into Table01 values(1,1,12,12,12,'2022','2022','ÓĞ','ÎŞ');

insert into OrderList05 values(99);
 update Table01 set TableType='ÎŞ'where TableNumber =13;
 
 update OrderList05 set OrderListNO=99;
 update Table01 set TableType = 'ÎŞ' where TableNumber = 12
select * from Table01 where TableType = 'ÓĞ'; 
select TableNumber from Table01;
select con(TableNumber) from Table01 where TableType = 'ÓĞ';
select COUNT(TableNumber) ±àºÅ from Table01 where TableType = 'ÓĞ';
select * from OrderTable04;

select * from OrderList05;

Truncate table OrderTable04;


Truncate table OrderList05;

Truncate table EverySingle02;
select * from VegetableDishes03;
insert into VegetableDishes03 values('³´²Ë','');
insert into VegetableDishes03 values('Á¹²Ë','');
insert into VegetableDishes03 values('º£ÏÊ','');



select EverySingle02.NO,Vegetables,VegetableDishes03.DishesType,OriginalCost,Discount,EverySingle02.Remark from EverySingle02 inner join VegetableDishes03 on EverySingle02.DishesType=VegetableDishes03.NO;
