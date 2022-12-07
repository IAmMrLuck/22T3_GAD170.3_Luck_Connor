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

        [SerializeField] private GameObject canvas;
        [SerializeField] private UnityEvent OnEnterTrigger;

        private Collider _collider;

        private void Awake()
        {
            _collider = GetComponent<Collider>();
            _collider.isTrigger = true;
        }
        private void OnTriggerEnter(Collider _collider)
        {

            // I'm just making sure that the trigger is activtaing - It Is!

            Debug.Log("TRIGGER TEST"); // here to test that the Trigger is firing

            // check if player character has collided with trigger 

            OnEnterTrigger.Invoke(); 
        }
    }
}
