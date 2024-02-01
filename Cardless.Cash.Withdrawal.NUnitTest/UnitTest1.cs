using Cardless.Cash.Withdrawal.Controllers;


namespace Cardless.Cash.Withdrawal.NUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //[Test]
        //public void Test1()
        //{
        //    HomeController home = new HomeController();
        //    string result = home.GetEmployeeName(1);
        //    Assert.AreEqual("Jignesh", result);
        //}

        [Test]
        public void TestLoginPageWithValidCredentials()
        {
            CardlessController loginObj = new CardlessController();
            string payIDType = "email";
            string payID = "pranjal.mishra@v2solutions.com";

            bool validateResult = loginObj.ValidateLoginCred(payIDType, payID);

            Assert.IsTrue(validateResult);
        
        }

        //[Test]
        //public void TestLoginPageWithBlankPayIDType()
        //{
        //    CardlessController loginObj = new CardlessController();
        //    string payIDType = "";
        //    string payID = "pranjal.mishra@v2solutions.com";

        //    bool validateResult = loginObj.ValidateLoginCred(payIDType, payID);

        //    Assert.IsTrue(validateResult);

        //}

        [Test]
        public void TestLoginPageWithBlankPayID()
        {
            CardlessController loginObj = new CardlessController();
            string payIDType = "email";
            string payID = "";

            bool validateResult = loginObj.ValidateLoginCred(payIDType, payID);

            Assert.IsTrue(validateResult);

        }

        [Test]
        public void TestLoginPageWithAllFieldsBlank()
        {
            CardlessController loginObj = new CardlessController();
            string payIDType = "";
            string payID = "";

            bool validateResult = loginObj.ValidateLoginCred(payIDType, payID);

            Assert.IsTrue(validateResult);

        }
        //Calling Test method with single Value
        [Test]
        public void TestLoginPageWithEmailID()
        {
            CardlessController loginObj = new CardlessController();

            string payIDType = "email";
            string payID = "pranjal.mishra@v2solution.com";

            bool validateResult = loginObj.ValidateLoginEmailID(payIDType, payID);

            Assert.IsTrue(validateResult);

        } 

        //Calling Test Method With Multiple Values
        [TestCase("email", "pranjal.mishra@v2solutions.com", true)]
        //[TestCase("email", "pranjal.mishra$v2solutions.com.in", false)]
        //[TestCase("email", "pranjal.mishra-v2solutions.com", false)]
        //[TestCase("email", "pranjal.mishra@v2solutions", false)]
        [TestCase("email", "pranjal.mishra@v2solutions.in", true)]
        public void TestLoginPageWithEmailID(string payIDType, string payID,bool expectedResult)
        {
            CardlessController loginObj = new CardlessController();            

            bool validateResult = loginObj.ValidateLoginEmailID(payIDType, payID);

            Assert.AreEqual(expectedResult, validateResult);

        }
    }
}