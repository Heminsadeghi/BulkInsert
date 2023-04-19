insert into [TestDB1].[dbo].[Person]   
(      [FirstName]
      ,[LastName]
      ,[Suffix]
      ,[Email]
      ,[AdditionalContactInfo]
      ,[ModifiedDate]
      ,[CreateDate]
 )
 values(
'Heeman'  , 'sadeghi'  ,'Test'  ,'aa@aa.com' 
,'Test' 
,getdate() 
,getdate() 

)

go 5000

