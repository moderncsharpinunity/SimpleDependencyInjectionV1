using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleDependencyInjection;
using UnityEngine;

namespace Example
{
    public class ExampleDependenciesContext : MonoBehaviour
    {
        [SerializeField]
        private ExampleDependencyMonoBehaviour exampleDependency = default;
        [SerializeField]
        private ExampleDependencyNested exampleDependencyNested = default;

        private void Awake()
        {
            DependenciesContext.Dependencies.Add(new Dependency { Type = typeof(ExampleDependencyMonoBehaviour), Factory = () => exampleDependency, IsSingleton = true });

            DependenciesContext.Dependencies.Add(new Dependency { Type = typeof(ExampleDependencyPlainClass), Factory = () => new ExampleDependencyPlainClass(), IsSingleton = false });

            DependenciesContext.Dependencies.Add(new Dependency { Type = typeof(ExampleDependencyNested), Factory = () => Instantiate(exampleDependencyNested).GetComponent<ExampleDependencyNested>(), IsSingleton = true });
        }
    }
}
