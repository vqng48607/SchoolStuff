using Scheduling;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        PCB pCB;

        [TestInitialize]

        public void InitializeTest()
        {
            pCB = new PCB();
            pCB.ProcessPriority = 2;
            pCB.ProcessName = "Test";
            pCB.ProcessState = ProcessStateType.Wait;

        }

        [TestMethod]
        public void changeProcessStateTest()
        {
            //Arrange som er det der ligger i initialize

            //Act
            pCB.ProcessState = ProcessStateType.Run;

            //Assert
            Assert.AreEqual(ProcessStateType.Run, pCB.ProcessState);
        }

        [TestMethod]
        public void changeProcessNameTest()
        {
            //Act
            pCB.ProcessName = "NameChanged";

            //Assert
            Assert.AreEqual("NameChanged", pCB.ProcessName);
        }

        [TestMethod]
        public void toStringTest1()
        {
            //Act
            string namePriority = pCB.ToString();

            //Assert
            Assert.AreEqual("Test(2)", namePriority);
        }

        [TestMethod]
        public void changeProcessNameAndProcessPriorityToStringTest()
        {
            //Act
            pCB.ProcessName = "NameChanged";
            pCB.ProcessPriority = 6;
            string namePriority = pCB.ToString();

            //Assert
            Assert.AreEqual("NameChanged(6)", namePriority);
        }
    }
}