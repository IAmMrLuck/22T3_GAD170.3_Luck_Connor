using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ConnorLuck
{

    public class FallSpawn : MonoBehaviour
    {
        // SerializeField allows the GameObject to be referenced in the inspector

        [SerializeField] GameObject PlayerCharacter;

        private void Update()
        {

            // This checks the players Y position to determine if they've fallen off the map
            // and then "kills" them and brings them back to the start of the level
            if (PlayerCharacter.transform.position.y < -30)
            {
                SceneManager.LoadScene("FirstShift");
            }
        }


    }
}
