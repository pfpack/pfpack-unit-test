﻿#nullable enable

namespace PrimeFuncPack.UnitTest.Moq
{
    public interface IFunc<in T1, in T2, out TResult>
    {
        TResult Invoke(T1 arg1, T2 arg2);
    }
}
