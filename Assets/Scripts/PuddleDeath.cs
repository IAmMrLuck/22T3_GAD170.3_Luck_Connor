using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ConnorLuck
{

    public class PuddleDeath : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            Debug.Log("You Slipped!");
        }
    }

}