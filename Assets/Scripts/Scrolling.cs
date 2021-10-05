using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scrolling : MonoBehaviour
{
    public Slider slider;
    private bool i = true;
    public int speed;

    private void Start()
    {
        slider.maxValue = 5;
        StartCoroutine(Scroll());
    }

    public void Click()
    {
        if (i == true) { i = false; }
        else { i = true; }
    }

    IEnumerator Scroll()
    {
        if (i==true)
        {
            slider.value += speed * Time.deltaTime;
            if (slider.value == 5)
            {
                i = false;
            }
        }
        else
        {
            slider.value -= speed * Time.deltaTime;
            if (slider.value == 0)
            {
                i = true;
            }
        }

        yield return new WaitForSeconds(0f);
        StartCoroutine(Scroll());
    }
}
