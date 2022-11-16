using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ConnorLuck
{

    public class PuddleDeath : MonoBehaviour
    {
        public GameObject Puddle;

        private void OnCollisionEnter(Collision _collision)
        {
            // this kills the character and sends them to the kill screen
            SceneManager.LoadScene("KillScreen");

        }
    }

}