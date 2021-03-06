// <copyright file="DayTest.cs">Copyright ©  2016</copyright>
using System;
using LemonadeStand;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LemonadeStand.Tests
{
    /// <summary>This class contains parameterized unit tests for Day</summary>
    [PexClass(typeof(Day))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class DayTest
    {
        /// <summary>Test stub for ProcessPotentials()</summary>
        [PexMethod]
        public void ProcessPotentialsTest([PexAssumeUnderTest]Day target)
        {
            target.ProcessPotentials();
            // TODO: add assertions to method DayTest.ProcessPotentialsTest(Day)
        }
    }
}
