using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.ProBuilder;
using UnityEngine.TextCore.Text;
using static ConnorLuck.BoxOrb;

namespace ConnorLuck
{


    public class BlockToggler : MonoBehaviour
    {
        [SerializeField] private GameObject block;
        [SerializeField] private Material tangibleMaterial;
        [SerializeField] private Material intangibleMaterial;
        [SerializeField] private UnityEvent OnEnterTrigger;

        public void OnEnable()
        {
            BoxOrb.OnKeyDown += TurnTangible;
        }
        public void OnDisable()
        {
            BoxOrb.OnKeyDown -= TurnTangible;
        }


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
