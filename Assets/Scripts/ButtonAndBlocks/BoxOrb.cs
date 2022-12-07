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


        public delegate void EKeyDown();
        public static event EKeyDown OnKeyDown;


        // if othergameobject.name "player character"

        //{ true or false - checks where the player is 

        // private bool isplayernearby

        // ontriggerenter

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.name == "PlayerCharacter") ;
               
        }

        private void Update()
        {
            if(Input.GetKeyUp(KeyCode.E))
            {
                OnKeyDown.Invoke();
            }
        }

    }
}