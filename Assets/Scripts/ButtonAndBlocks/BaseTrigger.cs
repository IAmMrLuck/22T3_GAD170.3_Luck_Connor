using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

    // prevents this from running without a collider component being attached - just another safety net
    // it could be further specified to be BoxCollider - but this is not essential
    [RequireComponent(typeof(Collider))]

    public class BaseTrigger : MonoBehaviour
    {

        public UnityEvent OnEnterTrigger;
        private Collider _collider;

        private void Awake()
        {
            _collider = GetComponent<Collider>();
            _collider.isTrigger = true;
        }
        private void OnTriggerEnter(Collider other)
        {

            // I'm just making sure that the trigger is activtaing - It Is!


            Debug.Log("TRIGGER button TEST"); // here to test that the Trigger is firing

            OnEnterTrigger.Invoke();
        }

    private void Update()
    {
        if(_collider == false)
        {
            GetComponent<Collider>().enabled = true; 
        }
    }

}
