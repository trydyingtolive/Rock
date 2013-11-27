drop view v_personattributevalue

create view v_personattributevalue as
SELECT 
  av.Id, 
  av.IsSystem, 
  av.AttributeId,
  av.EntityId,
  av.EntityId as [PersonId],
  av.[Order],
  av.Value, 
  av.Guid  
FROM  AttributeValue  av        
join Attribute a on a.Id = av.AttributeId
and a.EntityTypeId = (select Id from EntityType where Name = 'Rock.Model.Person')
