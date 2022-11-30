using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.Events;

namespace ConnorLuck
{

    public class BoxOrb : MonoBehaviour
    {

        // needs to know which blocks to activate
        // needs to know which method to call (Intangible or Tangible)
        [SerializeField] private UnityEvent TurnTangible;
        private BlockToggler blockToggler;
        [SerializeField] private BoxOrb transientBlockToActivate;

        private void ActivateTransientBlocks()

        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                TurnTangible.Invoke();


            }
        }

    }
}