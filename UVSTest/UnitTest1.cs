using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Controller.Infrastructure;
using Moq;
using DAL.Abstract;
using Controller.Abstract;
using Controller;
using Controller.Concrete;

namespace UVSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_RandomGenerator()
        {
            string result1 = RandomTextGenerator.GetRandomString(1);
            string result2 = RandomTextGenerator.GetRandomString(2);
            string result3 = RandomTextGenerator.GetRandomString(3);

            Assert.IsTrue(result1.Length >= 5 && result1.Length <= 10);
            Assert.IsTrue(result2.Length >= 5 && result2.Length <= 10);
            Assert.IsTrue(result3.Length >= 5 && result3.Length <= 10);

            Assert.AreNotEqual(result1, result2);
            Assert.AreNotEqual(result2, result3);
            Assert.AreNotEqual(result1, result3);
        }

        [TestMethod]
        public void Test_Controller_WriteToDatabase_OK()
        {
            var mockRepository = new Mock<IRepository>();
            var mockView = new Mock<IView>();

            var controller = new ControllerClass(mockView.Object, mockRepository.Object);
            var data = new GeneratedData() {ThreadID = 1, Data = "ABCDEFG", Time = DateTime.Now};

            controller.InsertToDatabase(data);

            mockRepository.Verify(x => x.Create(data.ThreadID, data.Data, data.Time), Times.Once);
        }

        [TestMethod]
        public void Test_Controller_WriteToDatabase_ERROR()
        {
            var mockRepository = new Mock<IRepository>();
            var mockView = new Mock<IView>();

            var controller = new ControllerClass(mockView.Object, mockRepository.Object);
            var data = new GeneratedData() { ThreadID = 1, Data = "ABCDEFG", Time = DateTime.Now };
            mockRepository.Setup(m => m.Create(data.ThreadID, data.Data, data.Time)).Throws<Exception>();

            controller.InsertToDatabase(data);
            mockView.Verify(m => m.DisableStopButton(), Times.AtLeast(1));
            mockView.Verify(m => m.EnableStartButton(), Times.AtLeast(1));
            mockView.Verify(m => m.ShowErrorMessage(It.IsAny<Exception>()), Times.Once);
        }

        [TestMethod]
        public void Test_Controller_Worker_Stop()
        {
            var mockRepository = new Mock<IRepository>();
            var mockView = new Mock<IView>();

            var controller = new ControllerClass(mockView.Object, mockRepository.Object);

            controller.Stop();
            mockView.Verify(m => m.DisableStopButton(), Times.AtLeast(1));
            mockView.Verify(m => m.EnableStartButton(), Times.AtLeast(1));
        }

        [TestMethod]
        public void Test_Worker()
        {
            var worker = new Worker(1);
            IGeneratedData workerData = new GeneratedData();
                     
            worker.DataGeneration += (IGeneratedData data) => { workerData = data; };

            //worker.StartWork();
            //worker.StopWork();           
        }
    }
}
