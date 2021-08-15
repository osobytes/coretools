using UnityEngine;

namespace Osobytes.Core
{
    public static class Requires
    {
        public static void DefinedBehaviour(MonoBehaviour requirement, string objectName)
        {
            Debug.Assert( requirement != null, $"GameObject {objectName} must be preconfigured or dragged into this component.");
        }

        public static void NullSingletonBehaviour<T>(T singleton, string behaviourName)
            where T : class
        {
            if(singleton != null)
            {
                Debug.LogError("A singleton behaviour is required in order to ");
            }
        }
    }
}