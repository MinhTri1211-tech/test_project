using System.Security.Cryptography.X509Certificates;
using UnitTestConsole;

namespace testproject
{
    [TestClass]
    public class Testproject
    {


            [TestMethod]
            public void testSalaryResearch_rank1_NUM1()
            {
                Researcher a= new Researcher();
                a.NumOfPaper = 1;
                a.PaperRank = 1;
                double b = a.GetSalary();
                Assert.AreEqual((0*1490+(1*10000))*0.99, b);


                
            }
        [TestMethod]
        public void testSalaryResearch_rank2_NUM1()
        {
            Researcher a = new Researcher();
            a.NumOfPaper = 1;
            a.PaperRank = 2;
            double b = a.GetSalary();
            Assert.AreEqual((0 * 1490 + (1 * 70000)) * 0.99, b);



        }
        [TestMethod]
        public void testSalaryResearch_rank3_NUM1()
        {
            Researcher a = new Researcher();
            a.NumOfPaper = 1;
            a.PaperRank = 3;
            double b = a.GetSalary();
            Assert.AreEqual((0 * 1490 + (1 * 50000)) * 0.99, b);



        }
        [TestMethod]
        public void testSalaryResearch_rank1_NUM2()
        {
            Researcher a = new Researcher();
            a.NumOfPaper = 2;
            a.PaperRank = 1;
            double b = a.GetSalary();
            Assert.AreEqual((0 * 1490 + (2 * 10000)) * 0.99, b);



        }

        [TestMethod]
        public void testSalaryTeacher_priorityequal1()
        {
            Teacher a = new Teacher();
            a.Seniority= 1;
            a.UnionMember = true;
            a.Factor = 1;   
            double b = a.GetSalary();
            Assert.AreEqual((1.25*1490*0.99) + (1*1000) , b);



        }
        [TestMethod]
        public void testSalaryTeacher_seniorityequal2()
        {
            Teacher a = new Teacher();
            a.Seniority = 2;
            a.UnionMember = true;
            a.Factor = 1;
            double b = a.GetSalary();
            Assert.AreEqual((1.25 * 1490 * 0.99) + (2 * 1000), b);



        }
        [TestMethod]
        public void testSalaryTeacher_seniorityequal3()
        {
            Teacher a = new Teacher();
            a.Seniority = 3;
            a.UnionMember = true;
            a.Factor = 1;
            double b = a.GetSalary();
            Assert.AreEqual((1.25 * 1490 * 0.99) + (3 * 1000), b);



        }
        [TestMethod]
        public void testSalaryTeacher_seniorityequal4()
        {
            Teacher a = new Teacher();
            a.Seniority = 4;
            a.UnionMember = true;
            a.Factor = 1;
            double b = a.GetSalary();
            Assert.AreEqual((1.25 * 1490 * 0.99) + (4 * 1000), b);



        }
    }
}