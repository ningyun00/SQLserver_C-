select * from EverySingle02;
/*����*/
insert into EverySingle02 values('�峴�ײ�',1,10.0,10.0,'');
insert into EverySingle02 values('���Ͱײ�',1,9.0,9.0,'');
insert into EverySingle02 values('ˮ��ײ�',1,5.0,5.0,'');
insert into EverySingle02 values('�ײ�',1,2.0,2.0,'');
select * from EverySingle02 where Vegetables = '�ײ�';

select * from EverySingle02 where OriginalCost !=Discount;
/*���*/
insert into EverySingle02 values('�����ݲ�',2,10.0,10.0,'');
insert into EverySingle02 values('�潴�ƹ�',2,10.0,10.0,'');
insert into EverySingle02 values('���ܲ�',2,12.0,12.0,'');
insert into EverySingle02 values('��̫��',2,12.0,12.0,'');
insert into EverySingle02 values('��˿�ϼ�',2,12.0,12.0,'');
insert into EverySingle02 values('�罷Ƥ��',2,16.0,16.0,'');
insert into EverySingle02 values('�ݽ�ľ��',2,16.0,16.0,'');
insert into EverySingle02 values('�����',2,16.0,16.0,'');
insert into EverySingle02 values('����ţ��',2,38.0,38.0,'');
insert into EverySingle02 values('��������',2,58.0,58.0,'');
/*����*/
insert into EverySingle02 values('������Ϻ',3,128.9,128.9,'ʱ��');

insert into Table01 values(1,1,12,12,12,'2022','2022','��','��');

insert into User_06 values('ning','123456');
select * from User_06 UserName ='ning' or UserPwd = '123456';

 update Table01 set TableType='��'where TableNumber =13;
 update EverySingle02 set Remark ={0} where Vegetables='{1}';
 update OrderList05 set OrderListNO=99;
 update Table01 set TableType = '��' where TableNumber = 12
select * from Table01 where TableType = '��'; 
select TableNumber from Table01;
select con(TableNumber) from Table01 where TableType = '��';
select COUNT(TableNumber) ��� from Table01 where TableType = '��';
select * from OrderTable04;
select NO,TableNumber,OrderNumber,Vegetables from OrderTable04;

select * from OrderList05;

Truncate table OrderTable04;


Truncate table OrderList05;

Truncate table EverySingle02;
select * from VegetableDishes03;
insert into VegetableDishes03 values('����','');
insert into VegetableDishes03 values('����','');
insert into VegetableDishes03 values('����','');



select EverySingle02.NO,Vegetables,VegetableDishes03.DishesType,OriginalCost,Discount,EverySingle02.Remark from EverySingle02 inner join VegetableDishes03 on EverySingle02.DishesType=VegetableDishes03.NO;
