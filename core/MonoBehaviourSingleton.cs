using UnityEngine;

namespace Osobytes.Core
{
    public class MonoBehaviourSingleton<T> : MonoBehaviour
        where T : MonoBehaviourSingleton<T>
    {

        public static T Instance { get; private set; }
        protected virtual void Awake()
        {
            Requires.NullSingletonBehaviour(Instance, nameof(T));
            Instance = (T) this;
        }
    }
}