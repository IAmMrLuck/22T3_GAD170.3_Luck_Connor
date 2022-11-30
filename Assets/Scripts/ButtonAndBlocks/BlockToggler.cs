using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder;

namespace ConnorLuck
{


    public class BlockToggler : MonoBehaviour
    {


        [SerializeField] private GameObject block;
        [SerializeField] private Material tangibleMaterial;
        [SerializeField] private Material intangibleMaterial;


        public void TurnIntangible()
        {
            if (block.GetComponent<BoxCollider>().enabled == true)
            {
                block.GetComponent<BoxCollider>().enabled = false;
                block.GetComponent<MeshRenderer>().material = intangibleMaterial;
            }

        }

        public void TurnTangible()
        {
            if (block.GetComponent<BoxCollider>().enabled == false)
            {
                block.GetComponent<BoxCollider>().enabled = true;
                block.GetComponent<MeshRenderer>().material = tangibleMaterial;
            }
        }

    }
}
