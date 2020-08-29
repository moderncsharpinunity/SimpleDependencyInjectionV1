using SimpleDependencyInjection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Example
{
    public class ExampleDependant : MonoBehaviour
    {
        private ExampleDependencyMonoBehaviour dependency = null;
        private ExampleDependencyPlainClass dependency2 = null;

        private void Awake()
        {
            dependency = DependenciesContext.Dependencies.Get<ExampleDependencyMonoBehaviour>();
            dependency2 = DependenciesContext.Dependencies.Get<ExampleDependencyPlainClass>();
           
        }

        void Start()
        {
            dependency.DoSomethingComplex();

            dependency2.DoSomethingAlsoComplex();
        }
    }
}