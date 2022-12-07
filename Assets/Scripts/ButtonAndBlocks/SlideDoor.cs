using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.UIElements;

namespace ConnorLuck
{

    public class SlideDoor : MonoBehaviour
    {
        private Animator _animation;
        [SerializeField] private UnityEvent PlayAnimation;

        public UnityEvent OnEnterTrigger;
        private Collider _collider;

        private void Awake()
        {
            _collider = GetComponent<Collider>();
            _collider.isTrigger = true;
            _animation = gameObject.GetComponent<Animator>();
        }
        private void OnTriggerEnter(Collider _collider)
        {
            // I'm just making sure that the trigger is activtaing - It Is!
            Debug.Log("TRIGGER button TEST"); // here to test that the Trigger is firing
            OnEnterTrigger.Invoke();
        }
         
         public void Update()
         {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Pressed");

                _animation.Play("DoorSlideAnim");

            }
         }

        

    }

}