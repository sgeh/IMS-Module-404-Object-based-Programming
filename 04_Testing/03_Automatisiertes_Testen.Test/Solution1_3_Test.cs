using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/// <summary>
/// ---------------------------------------------------------------------------
/// Übungsserie 03
/// Thema: Automatisiertes Testen
/// Author: Silvan Gehrig
/// Version: 1.0
/// -------------------------------------------------------------------- 2021 -
/// </summary>
namespace Bwz.Rappi.Test
{
    [TestClass]
    public class Solution1_3_Test
    {
        [TestMethod]
        public void TestPythagoras_SideC()
        {
            double a = 56;
            double b = 90;
            double resultC = 106;
            Assert.AreEqual(resultC, Solution1_2.CalculateC(a, b));
        }
    }
}
