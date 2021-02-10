﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Diagnostics;

namespace Microsoft.VisualStudio.LanguageServerClient.Razor.Logging
{
    internal abstract class LogHubLogWriter
    {
        public abstract void Write(string message);
        public abstract void Write(string format, params object[] args);
        public abstract TraceSource GetTraceSource();
    }
}
