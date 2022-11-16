using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ConnorLuck
{
    public class StartShift : MonoBehaviour
    {

        public void OnStartClick()
        {
          // this is attched to a button in the UI and it loads the start of the game.
            // Debug.Log("Clicked");
           SceneManager.LoadScene("FirstShift");

        }
    }
}
