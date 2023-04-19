      	use TestDB1
		go
		drop table if exists  Person
		go
	  create table Person( ID int IDENTITY(1,1) NOT NULL
	   , FirstName  nvarchar(100), LastName nvarchar(100),Suffix nvarchar(100),
	   Email  nvarchar(100),AdditionalContactInfo nvarchar(100),
	     ModifiedDate datetime,  CreateDate datetime
	   )
	    go
		use TestDB2
		go
		drop table if exists  Person
		go
		create table Person( ID int IDENTITY(1,1) NOT NULL
	   , FirstName  nvarchar(100), LastName nvarchar(100),Suffix nvarchar(100),
	   Email  nvarchar(100),AdditionalContactInfo nvarchar(100),
	     ModifiedDate datetime,  CreateDate datetime
	   )
	    
      
     
