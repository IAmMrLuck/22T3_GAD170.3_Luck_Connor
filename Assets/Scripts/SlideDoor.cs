using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class SlideDoor : MonoBehaviour
{

    private KeyDownEvent doorSlider;

    public KeyDownEvent DoorSlider { get => doorSlider; set => doorSlider = value; }

    private void Awake()

    {
        //DoorSlider = GetComponent<KeyDownEvent>();
    }



}
