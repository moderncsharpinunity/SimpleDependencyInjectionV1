using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace SimpleDependencyInjection
{
    public static class DependenciesContext
    {
        public static DependenciesCollection Dependencies { get; } = new DependenciesCollection();
    }
}