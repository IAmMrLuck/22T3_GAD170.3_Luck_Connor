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
        [SerializeField] private bool isPlayerCharacterNearby = false;

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
            if (_collider.gameObject.name == "PlayerCharacter") ;
            isPlayerCharacterNearby = true;
        }

        private void OnTriggerExit(Collider _collider)
        {
            if (_collider.gameObject.name == "PlayerCharacter") ;
            isPlayerCharacterNearby = false;
        }
        
         public void Update()
         {
            if (Input.GetKeyDown(KeyCode.E) && isPlayerCharacterNearby == true)
            {
                Debug.Log("Pressed");

                _animation.Play("DoorSlideAnim");

            }
         }

        

    }

}