﻿#region License
// 
// Copyright (c) 2013, Kooboo team
// 
// Licensed under the BSD License
// See the file LICENSE.txt for details.
// 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kooboo.Web.Css
{
    public class SelectorGroup : List<Selector>
    {
        public override string ToString()
        {
            return String.Join(", ", this.Select(o => o.ToString()));
        }
    }
}
