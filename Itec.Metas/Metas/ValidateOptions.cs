﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Itec.Metas
{
    [Flags]
    public enum ValidateOptions
    {
        Undefined=0,
        IgnoreRequire=1,
        DefaultAsNull=1<<1
    }
}
