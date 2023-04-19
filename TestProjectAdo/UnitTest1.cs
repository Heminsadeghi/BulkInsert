

namespace TestProjectAdo
{
    public class UnitBlukInsertPerson
    {
        [Fact]
        public void Task_GetData_Person()
        {
            // Arrange  
            DataBaseCommon dataBase = new DataBaseCommon();
            string ConntionStringSource = "Password=123;Persist Security Info=True;User ID=sad;Initial Catalog=TestDB1;Data Source=.;TrustServerCertificate=True";

            // Act  
            var data = dataBase.GetData(ConntionStringSource, "Person", "FirstName,LastName,Suffix,Email,AdditionalContactInfo,ModifiedDate,CreateDate");


            //Assert  
            Assert.Equal(data.Rows.Count, 5000);


        }


        [Fact]
        public void Task_InsertData_Person()
        {
            // Arrange  
            
            DataBaseCommon dataBase = new DataBaseCommon();
            string ConntionStringSource = "Password=123;Persist Security Info=True;User ID=TestUser;Initial Catalog=TestDB1;Data Source=.;TrustServerCertificate=True";
            string ConntionStringDes = "Password=123;Persist Security Info=True;User ID=TestUser;Initial Catalog=TestDB2;Data Source=.;TrustServerCertificate=True";


            // Act  
            var data = dataBase.GetData(ConntionStringSource, "Person", "FirstName,LastName,Suffix,Email,AdditionalContactInfo,ModifiedDate,CreateDate");
            dataBase.InsertData(ConntionStringDes, "Person", data);
            var datades = dataBase.GetData(ConntionStringDes, "Person", "FirstName,LastName,Suffix,Email,AdditionalContactInfo,ModifiedDate,CreateDate");


            //Assert  
            Assert.Equal(datades.Rows.Count, data.Rows.Count);


        }
    }
}