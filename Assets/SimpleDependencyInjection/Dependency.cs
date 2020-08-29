using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleDependencyInjection
{
    public struct Dependency
    {
        public Type Type { get; set; }
        public Func<object> Factory { get; set; }
        public object Instance { get; set; }
        public bool IsSingleton { get; set; }
    }
}