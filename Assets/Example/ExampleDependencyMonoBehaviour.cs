using SimpleDependencyInjection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Example
{
    public class ExampleDependencyMonoBehaviour : MonoBehaviour
    {
        private ExampleDependencyNested dependencyNested = default;

        private void Awake()
        {
            dependencyNested = DependenciesContext.Dependencies.Get<ExampleDependencyNested>();            
        }

        public void DoSomethingComplex()
        {

            dependencyNested.DoSomethingSimple();

            Debug.Log("Something complex just happened: " + gameObject.GetInstanceID());
        }
    }
}