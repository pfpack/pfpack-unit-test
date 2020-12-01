﻿#nullable enable

using Moq;
using System;
using Xunit;

namespace PrimeFuncPack.UnitTest.Moq.Tests
{
    partial class MockActionFactoryTests
    {
        [Fact]
        public void CreateMockAction_07_ThenInvoke_ExpectCallMockInvokeOnce()
        {
            var actualMock = MockActionFactory.CreateMockAction<string, SomeStruct, object, string?, int, SomeStruct, DateTime?>();

            var arg1 = "Some Text";
            var arg2 = new SomeStruct
            {
                Id = 11
            };
            var arg3 = new
            {
                Value = "Some Third"
            };
            var arg4 = default(string?);
            var arg5 = 15;
            var arg6 = default(SomeStruct);
            var arg7 = Year2020May11;

            actualMock.Object.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
            actualMock.Verify(f => f.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7), Times.Once);
        }
    }
}