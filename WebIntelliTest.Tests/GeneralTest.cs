// <copyright file="GeneralTest.cs">Copyright ©  2018</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebIntelliTest.BusinessCode;

namespace WebIntelliTest.BusinessCode.Tests
{
    [TestClass]
    [PexClass(typeof(General))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class GeneralTest
    {

        [PexMethod]
        public int AddTwoPositiveNumber(
            [PexAssumeUnderTest]General target,
            int a,
            int b
        )
        {
            int result = target.AddTwoPositiveNumber(a, b);
            return result;
            // TODO: add assertions to method GeneralTest.AddTwoPositiveNumber(General, Int32, Int32)
        }
    }
}
