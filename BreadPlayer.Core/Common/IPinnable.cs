﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreadPlayer.Core.Common
{
    public interface IPinnable
    {
        bool IsPinned { get; set; }
        string TileId { get; }
    }
}
