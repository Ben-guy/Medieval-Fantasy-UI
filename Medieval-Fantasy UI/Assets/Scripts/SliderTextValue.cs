using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderTextValue : MonoBehaviour
{
    public Slider wantedSlider;
    private Text sliderTextValue;

    private void Awake()
    {
        sliderValue();
    }
    public void sliderValue()
    {
        sliderTextValue = wantedSlider.GetComponentInChildren<Text>();
        sliderTextValue.text = wantedSlider.value.ToString() + (" %");

    }

}
