using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ConnorLuck
{


    public class DeathRestart : MonoBehaviour
    {


        public void OnRestartClick()
        {
            // this is attched to a button in the UI and it reloads the main menu
           
            SceneManager.LoadScene("StartMenuScript");

        }

    }
}
