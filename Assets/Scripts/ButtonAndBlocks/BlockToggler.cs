using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.ProBuilder;
using UnityEngine.TextCore.Text;

namespace ConnorLuck
{


    public class BlockToggler : MonoBehaviour
    {
        private void OnEnable()
        {
            BoxOrb.OnKeyDown += TurnTangible;
        }

        private void OnDisable()
        {
            BoxOrb.OnKeyDown -= TurnTangible;
        }

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
