using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleDependencyInjection
{
    public class DependenciesCollection : IEnumerable<Dependency>
    {
        private Dictionary<Type, Dependency> dependencies = new Dictionary<Type, Dependency>();

        public void Add(Dependency dependency) => dependencies.Add(dependency.Type, dependency);

        public object Get(Type type)
        {
            if (!dependencies.ContainsKey(type))
            {
                throw new ArgumentException("Type is not a dependency: " + type.FullName);
            }

            var dependency = dependencies[type];
            if (dependency.IsSingleton)
            {
                if (dependency.Instance == null)
                {
                    dependency.Instance = dependency.Factory();
                    dependencies[type] = dependency;
                }
                return dependency.Instance;
            }
            else
            {
                return dependency.Factory();
            }
        }

        public T Get<T>()
        {
            return (T)Get(typeof(T));
        }

        public IEnumerator<Dependency> GetEnumerator() => dependencies.Values.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => dependencies.Values.GetEnumerator();
    }
}