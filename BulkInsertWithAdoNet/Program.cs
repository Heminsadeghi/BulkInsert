using BulkInsertWithAdoNet.Data;

DataBaseCommon dataBase = new DataBaseCommon();
string ConntionStringSource = "Password=123;Persist Security Info=True;User ID=TestUser;Initial Catalog=TestDB1;Data Source=.;TrustServerCertificate=True";
string ConntionStringDes = "Password=123;Persist Security Info=True;User ID=TestUser;Initial Catalog=TestDB2;Data Source=.;TrustServerCertificate=True";

var data = dataBase.GetData(ConntionStringSource, "Person", "FirstName,LastName,Suffix,Email,AdditionalContactInfo,ModifiedDate,CreateDate");
dataBase.InsertData(ConntionStringDes, "Person", data);

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
