﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScottPlot.Common.Tests
{
    internal class ColorTests
    {
        [TestCase("#abcdef", 0xAB, 0xCD, 0xEF, 0xFF)]
        [TestCase("#ABCDEF", 0xAB, 0xCD, 0xEF, 0xFF)]
        [TestCase("#123456", 0x12, 0x34, 0x56, 0xFF)]
        [TestCase("#abcdefaa", 0xAB, 0xCD, 0xEF, 0xAA)]
        [TestCase("#ABCDEFaa", 0xAB, 0xCD, 0xEF, 0xAA)]
        [TestCase("#123456aa", 0x12, 0x34, 0x56, 0xAA)]
        public void TestFromHex(string hex, byte expectedR, byte expectedG, byte expectedB, byte expectedA)
        {
            Color actual = Color.FromHex(hex);
            Assert.AreEqual(expectedR, actual.Red);
            Assert.AreEqual(expectedG, actual.Green);
            Assert.AreEqual(expectedB, actual.Blue);
            Assert.AreEqual(expectedA, actual.Alpha);
        }
    }
}
