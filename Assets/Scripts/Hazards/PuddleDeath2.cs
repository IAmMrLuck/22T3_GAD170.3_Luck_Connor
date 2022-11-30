using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ConnorLuck

{
    public class PuddleDeath2 : MonoBehaviour
    {

        void OnCollisionEnter(Collision _collision)
        {
            SceneManager.LoadScene("FirstShift");
        }
    }
}
