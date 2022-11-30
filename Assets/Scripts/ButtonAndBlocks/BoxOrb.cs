using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.Events;

namespace ConnorLuck
{

    public class BoxOrb : MonoBehaviour
    {

        public delegate void EKeyDown();
        public static event EKeyDown OnKeyDown;

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                if(OnKeyDown != null)
                OnKeyDown();


            }
        }

    }
}