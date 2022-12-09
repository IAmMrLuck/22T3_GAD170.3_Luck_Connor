using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

namespace ConnorLuck
{

    public class BoxOrb : MonoBehaviour
    {

        [SerializeField] private bool isPlayerCharacterNearby = false;
        public delegate void EKeyDown();
        public static event EKeyDown OnKeyDown;

        // checks if the player has entered into the trigger 
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.name == "PlayerCharacter"); 
               isPlayerCharacterNearby=true;
        }


        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.name == "PlayerCharacter");
            isPlayerCharacterNearby=false;
        }

        // if the player clicks the "E" key, then they can interact with the interacble. 
        // provided that they are also in the collider
        private void Update()
        {
            if(Input.GetKeyUp(KeyCode.E) && isPlayerCharacterNearby == true )
            {
                OnKeyDown.Invoke();
            }
        }

    }
}