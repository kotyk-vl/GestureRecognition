using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GestureRecognition;
namespace GestureRecognition.Tests
{
    [TestClass]
    public class RecognitionTests
    {
        //string Path = Environment.CurrentDirectory;
        string Path = @"C:\Users\Vlad Kotyk\Desktop\Image1";
        [TestMethod]
        public void _1()
        {
            LoadModel.Meth(Path + "\\1\\53.png");
            string res = LoadModel.PredictLabel;
            Assert.AreEqual(res, "1");

        }
        [TestMethod]
        public void _2()
        {
            LoadModel.Meth(Path + "\\2\\60.png");
            string res = LoadModel.PredictLabel;
            Assert.AreEqual(res, "2");

        }
        [TestMethod]
        public void _3()
        {
            LoadModel.Meth(Path + "\\3\\73.png");
            string res = LoadModel.PredictLabel;
            Assert.AreEqual(res, "3");

        }
        [TestMethod]
        public void _A()
        {
            LoadModel.Meth(Path + "\\A\\21.png");
            string res = LoadModel.PredictLabel;
            Assert.AreEqual(res, "A");

        }
        [TestMethod]
        public void _B()
        {
            LoadModel.Meth(Path + "\\B\\39.png");
            string res = LoadModel.PredictLabel;
            Assert.AreEqual(res, "B");

        }
        [TestMethod]
        public void _C()
        {
            LoadModel.Meth(Path + "\\C\\44.png");
            string res = LoadModel.PredictLabel;
            Assert.AreEqual(res, "C");

        }
        [TestMethod]
        public void _Hello()
        {
            LoadModel.Meth(Path + "\\Hello\\02.png");
            string res = LoadModel.PredictLabel;
            Assert.AreEqual(res, "Hello");

        }
        [TestMethod]
        public void _I_love_you()
        {
            LoadModel.Meth(Path + "\\I_love_you\\09.png");
            string res = LoadModel.PredictLabel;
            Assert.AreEqual(res, "I_love_you");

        }
        [TestMethod]
        public void _No()
        {
            LoadModel.Meth(Path + "\\No\\01.png");
            string res = LoadModel.PredictLabel;
            Assert.AreEqual(res, "No");

        }
        [TestMethod]
        public void _Yes()
        {
            LoadModel.Meth(Path + "\\Yes\\19.png");
            string res = LoadModel.PredictLabel;
            Assert.AreEqual(res, "Yes");

        }
        [TestMethod]
        public void _1_1()
        {
            LoadModel.Meth(Path + "\\Test\\1.png");
            string res = LoadModel.PredictLabel;
            Assert.AreEqual(res, "1");

        }
        [TestMethod]
        public void _2_2()
        {
            LoadModel.Meth(Path + "\\Test\\2.png");
            string res = LoadModel.PredictLabel;
            Assert.AreEqual(res, "2");

        }
        [TestMethod]
        public void _3_3()
        {
            LoadModel.Meth(Path + "\\Test\\3.png");
            string res = LoadModel.PredictLabel;
            Assert.AreEqual(res, "2");

        }
        [TestMethod]
        public void _3_2()
        {
            LoadModel.Meth(Path + "\\Test\\3_2.png");
            string res = LoadModel.PredictLabel;
            Assert.AreEqual(res, "3");

        }
        [TestMethod]
        public void _A_1()
        {
            LoadModel.Meth(Path + "\\Test\\A.png");
            string res = LoadModel.PredictLabel;
            Assert.AreEqual(res, "A");

        }
        [TestMethod]
        public void _B_1()
        {
            LoadModel.Meth(Path + "\\Test\\B.png");
            string res = LoadModel.PredictLabel;
            Assert.AreEqual(res, "B");

        }
        [TestMethod]
        public void _B_2()
        {
            LoadModel.Meth(Path + "\\Test\\B_2.png");
            string res = LoadModel.PredictLabel;
            Assert.AreEqual(res, "2");

        }
        [TestMethod]
        public void _C_1()
        {
            LoadModel.Meth(Path + "\\Test\\C.png");
            string res = LoadModel.PredictLabel;
            Assert.AreEqual(res, "Yes");

        }
        [TestMethod]
        public void _Hello_1()
        {
            LoadModel.Meth(Path + "\\Test\\Hello.png");
            string res = LoadModel.PredictLabel;
            Assert.AreEqual(res, "Hello");

        }
        [TestMethod]
        public void _C_2()
        {
            LoadModel.Meth(Path + "\\Test\\C_2.png");
            string res = LoadModel.PredictLabel;
            Assert.AreEqual(res, "Yes");

        }
        [TestMethod]
        public void _Hello_2()
        {
            LoadModel.Meth(Path + "\\Test\\Hello_2.png");
            string res = LoadModel.PredictLabel;
            Assert.AreEqual(res, "2");

        }
        [TestMethod]
        public void _I_love_you_1()
        {
            LoadModel.Meth(Path + "\\Test\\I_love_you.png");
            string res = LoadModel.PredictLabel;
            Assert.AreEqual(res, "I_love_you");

        }
        [TestMethod]
        public void _No_1()
        {
            LoadModel.Meth(Path + "\\Test\\No.png");
            string res = LoadModel.PredictLabel;
            Assert.AreEqual(res, "No");

        }
        [TestMethod]
        public void _Yes_1()
        {
            LoadModel.Meth(Path + "\\Test\\Yes.png");
            string res = LoadModel.PredictLabel;
            Assert.AreEqual(res, "Yes");

        }
    }
}
   