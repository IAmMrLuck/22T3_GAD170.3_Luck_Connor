using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ConnorLuck
{



    public class QuitApplication : MonoBehaviour
    {

        
             void OnQuitClick()
            {
                // this is attched to a button in the UI and it loads the start of the game.
                // Debug.Log("Clicked");
                SceneManager.LoadScene("FirstShift");

            }
        


    }
}
