// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System.Runtime.InteropServices;
using System;

internal class NullableTest
{
    private static bool BoxUnboxToNQ(object o)
    {
        return Helper.Compare((EmptyStruct)o, Helper.Create(default(EmptyStruct)));
    }

    private static bool BoxUnboxToQ(object o)
    {
        return Helper.Compare((EmptyStruct?)o, Helper.Create(default(EmptyStruct)));
    }

    private static int Main()
    {
        EmptyStruct? s = Helper.Create(default(EmptyStruct));

        if (BoxUnboxToNQ(s) && BoxUnboxToQ(s))
            return ExitCode.Passed;
        else
            return ExitCode.Failed;
    }
}


