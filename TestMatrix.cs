using System;
using System.Collections.Generic;
using System.Text;
using NUnit;
using NUnit.Framework;
using Matrix;

#pragma warning disable CA1707

namespace Matrix.Test
{
    [TestFixture]
    class TestMatrix
    {
        [Test]
        public void MyTestMatrix()
        {
            var testMatrix = new Matrix(3, 3);
            testMatrix[0, 0] = 1;
            testMatrix[0, 1] = 3;
            testMatrix[0, 2] = -2;
            testMatrix[1, 0] = 1;
            testMatrix[1, 1] = 0;
            testMatrix[1, 2] = 7;
            testMatrix[2, 0] = 1;
            testMatrix[2, 1] = 1;
            testMatrix[2, 2] = -1;

            var testMatrix1 = new Matrix(3, 3);
            testMatrix1[0, 0] = 1*5;
            testMatrix1[0, 1] = 3*5;
            testMatrix1[0, 2] = -2*5;
            testMatrix1[1, 0] = 1*5;
            testMatrix1[1, 1] = 0*5;
            testMatrix1[1, 2] = 7*5;
            testMatrix1[2, 0] = 1*5;
            testMatrix1[2, 1] = 1*5;
            testMatrix1[2, 2] = -1*5;

            testMatrix.CreateTransposeMatrix();

           // testMatrix = testMatrix * 5;

            Assert.AreEqual(testMatrix1, testMatrix*5);
            Assert.Pass("No pasaran");
        }
    }
}
