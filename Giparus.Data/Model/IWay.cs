﻿using System.Collections.Generic;

namespace Giparus.Data.Model
{
    public interface IWay
    {
        IList<long> NodeIds { get; set; }
        void MakeWay(Dictionary<long, INode> nodes);
    }
}
