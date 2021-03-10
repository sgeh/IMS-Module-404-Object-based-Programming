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
    public class Solution1_2_Test
    {
        [TestMethod]
        public void TestPythagoras_SideC()
        {
            double a = 3;
            double b = 4;
            double resultC = 5;
            Assert.AreEqual(resultC, Solution1_2.CalculateC(a, b));
        }
    }
}
