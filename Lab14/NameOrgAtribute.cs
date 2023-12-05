﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor)]
    internal class NameOrgAtribute : System.Attribute
    {
        public string Name { get; }
        public string Organization { get; set; }
        public NameOrgAtribute(string name, string organization)
        {
            Name = name;
            Organization = organization;
        }
        public NameOrgAtribute() { }
    }
}
