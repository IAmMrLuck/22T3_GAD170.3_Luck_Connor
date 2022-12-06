using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.Events;

namespace ConnorLuck
{

    public class BoxOrb : MonoBehaviour
    {
        [SerializeField] private UnityEvent OnEnterTrigger;

        public delegate void EKeyDown();
        public static event EKeyDown OnKeyDown;

        public void OnTriggerEnter(Collider other)
        {
            OnEnterTrigger.Invoke();
            
        }

    }
}