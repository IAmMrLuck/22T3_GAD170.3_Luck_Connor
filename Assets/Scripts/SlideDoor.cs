using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class SlideDoor : MonoBehaviour
{

    public UnityEvent OnEnterTrigger;
    private Clickable doorSlider;
    public bool alreadyEntered = false;
    private void Awake()

    {
        doorSlider = GetComponent<Clickable>();
    }

    private void OnPointerClick()
    {
        if (doorSlider != null) ;
    }

}
