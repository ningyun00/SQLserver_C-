select * from UserInfo;select * from CustomerTab;
select * from WareInFo;select * from WarePrice;select * from WareType;
insert into WareType values('商品名称','无备注');
select wareTypeId,waerTypeName from WareType;
delete from WareType where waerTypeName = '商品名称'; 
delete from CustomerTab where tabId ='';
select* from WareInfo where wareUpAndDown =1;
select * from WareInfo inner join WareType on WareInfo.wareTypeId = WareType.wareTypeId;
insert into WareInfo values('{0}','{1}','{2}','{3}','{4}','{5}');
insert into CustomerTab values(200,12345,GETDATE(),'无');
select * from CustomerTab where tabId = 1;
select wareId,wareName from WareInFo;
select WarePrice from WarePrice where wareId = 1;
select * from WarePrice;select * from WareType;
select warePrice from WareInFo inner join WarePrice on WareInFo.wareId = WarePrice.wareId where wareName = '哇哈哈';
select * from WarePrice;
select WareInFo.wareId,wareName,warePrice from WareInFo inner join WarePrice on WareInFo.wareId = WarePrice.wareId;
select WareInFo.wareId,wareName,warePrice from WareInFo inner join WarePrice on WareInFo.wareId = WarePrice.wareId where WareInFo.wareId = 1;
insert into WarePrice values(5,10,20,'无');








