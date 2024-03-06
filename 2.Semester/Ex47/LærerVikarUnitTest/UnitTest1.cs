using System.Data.Common;
using ModelPersistence.Models;
using ModelPersistence.Persistence;

namespace LærerVikarUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        SchoolRepo schoolRepo = new SchoolRepo();

        [TestMethod]
        public void GetAllSchool()
        {
            List<School> schools = schoolRepo.GetAll();

            Assert.AreEqual(9, schools.Count);
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange
            School school = schoolRepo.GetById("Vuongs_Skole", "Vuongsvej");

            // Assert
            Assert.AreEqual("Vuongs_Skole Vuong 23423423 Vuongsvej Vuong.com False", school.ToString());
        }

        [TestMethod]
        public void MyUpdate()
        {
            // Arrange
            List<School> schools = schoolRepo.Update("Vuongs_Skole", "Vuongsvej", 321);
            School school = schoolRepo.GetById("Vuongs_Skole", "Vuongsvej");

            // Assert
            Assert.AreEqual("Vuongs_Skole Vuong 321 Vuongsvej Vuong.com False", school.ToString());
        }

        [TestMethod]
        public void AddSchool()
        {
            List<School> schools = schoolRepo.Add("Vuongs_Skole", "Vuong", 23423423, "Vuongsvej", "Vuong.com", false);
            List<School> school = schoolRepo.GetAll();

            Assert.AreEqual(9, school.Count);
        }

        [TestMethod]
        public void RemoveSchool()
        {
            List<School> schools = schoolRepo.Delete("Vuongs_Skole", "Vuongsvej");
            List<School> school = schoolRepo.GetAll();

            Assert.AreEqual(8, school.Count);
        }
    }
}