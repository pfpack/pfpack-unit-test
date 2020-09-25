﻿#nullable enable

using Moq;
using NUnit.Framework;
using PrimeFuncPack.Core.Infrastructure.Tests.Stubs;
using PrimeFuncPack.UnitTest.Data;
using PrimeFuncPack.UnitTest.Moq;
using System;

namespace PrimeFuncPack.Core.Infrastructure.Tests
{
    partial class BoxTests
    {
        [Test]
        public void ToString_ValueIsNull_ExpectEmpty()
        {
            StructType? source = null;
            var box = new Box<StructType?>(source);

            var actual = box.ToString();
            Assert.IsEmpty(actual);
        }

        [Test]
        public void ToString_ValueIsNotNull_ExpectCallSourceToStringOnce()
        {
            var mockStringFactory = MockFuncFactory.CreateMockFunc("Some Text");
            var source = new StubType(mockStringFactory.Object);

            var box = new Box<StubType>(source);
            _ = box.ToString();

            mockStringFactory.Verify(f => f.Invoke(), Times.Once);
        }

        [Test]
        [TestCase("")]
        [TestCase("\t")]
        [TestCase("Some Value")]
        public void ToString_ValueToStringIsNotNull_ExpectResultIsValueToString(
            in string? valueToStringResult)
        {
            var mockStringFactory = MockFuncFactory.CreateMockFunc(valueToStringResult);
            var source = new StubType(mockStringFactory.Object);

            var box = new Box<StubType>(source);
            var actual = box.ToString();

            Assert.AreEqual(valueToStringResult, actual);
        }

        [Test]
        public void ToString_ValueToStringIsNull_ExpectEmpty()
        {
            var mockStringFactory = MockFuncFactory.CreateMockFunc<string?>(null);
            var source = new StubType(mockStringFactory.Object);

            var box = new Box<StubType>(source);
            var actual = box.ToString();

            Assert.IsEmpty(actual);
        }
    }
}