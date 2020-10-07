using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var arr = new[] { -1, -9, 9, -6, 2, -9, 7, -1, -2, 1 };

            var arrExpected = new[] { -1, -81, -6, 2, -9, -7, -2, 1 };

            var arrActual = ChangeArray(arr);

            CollectionAssert.AreEqual(arrExpected, arrActual);
        }

        public static int[] ChangeArray(int[] intArray)
        {
            for (int i = 0; i < intArray.Length - 1; i++)
            {
                if ((intArray[i] + intArray[i + 1]) % 3 == 0)
                {
                    intArray[i] = intArray[i] * intArray[i + 1];

                    for (int j = i + 1; j < intArray.Length - 1; j++)
                    {
                        intArray[j] = intArray[j + 1];
                    }

                    Array.Resize(ref intArray, intArray.Length - 1);
                }
            }


            return intArray;
        }
    }
}
