using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

namespace ConnorLuck
{
    // prevents this from running without a collider component being attached - just another safety net
    // it could be further specified to be BoxCollider - but this is not essential
    [RequireComponent(typeof(Collider))]  

    public class TriggerVolume : MonoBehaviour
    {

        [Header("Settings")]
        [SerializeField] private bool oneShot = true; // used to turn on or off the option to trigegr this only once



        public GameObject canvas;
        public UnityEvent OnEnterTrigger;
        public UnityEvent OnExitTrigger;
        private Collider _collider;
        public bool alreadyEntered = false;
        private void Awake()
        {
            _collider = GetComponent<Collider>();
            _collider.isTrigger = true;
        }
        private void OnTriggerEnter(Collider _collider)
        {

            // I'm just making sure that the trigger is activtaing - It Is!
            if (oneShot && alreadyEntered) return; // functionality to stop the trigger from firing again if it has been triggered once

            Debug.Log("TRIGGER TEST"); // here to test that the Trigger is firing

            // check if player character has collided with trigger 

            OnEnterTrigger.Invoke();
            canvas.SetActive(true);
            alreadyEntered = true;

            
        }

        private void OnTriggerExit(Collider _collider)
        {
            OnExitTrigger.Invoke();
            canvas.SetActive(false);
        }












        [Header("Gizmo Settings")]
        [SerializeField] private bool displayGizmos = false; // used to turn on or off the outline for the Gizmo 

        // functionanility to help see/edit the Trigger in future - so that we can remove the Mesh Renderer for gameplay
        // relates to displayGizmos as above
        private void OnDrawGizmos()
        {

            if (displayGizmos == false)   return;

            if (_collider == null)
            {
                _collider = GetComponent<Collider>();
            }
            Gizmos.DrawCube(transform.position, _collider.bounds.size);
        }
        private void OnDrawGizmosSelected()
        {
            if (displayGizmos == false)
                return;
        }
    }
}
