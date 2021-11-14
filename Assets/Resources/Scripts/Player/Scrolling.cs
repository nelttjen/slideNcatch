using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scrolling : MonoBehaviour
{
    public Slider slider;
    private bool i = true;
    public int speed = 5;

    private void Start()
    {
        slider.maxValue = 5;          //«адаЄм максимальное значение слайдера(игрока)
        StartCoroutine(Scroll());          //«апускаем куратину на движение слайдера(игрока)
    }

    public void Click()          //ћетод дл€ смены направлени€ при клике
    {
        if (i == true) { i = false; }
        else { i = true; }
    }

    IEnumerator Scroll()          // уратина дл€ движени€ слайдера(игрока)
    {
        if (i==true)
        {
            slider.value += speed * Time.deltaTime;          //”величиваем значение слайдера до максимального
            if (slider.value == 5)          //≈сли значение слайдера на 5, то мен€ем направление
            {
                i = false;
            }
        }
        else
        {
            slider.value -= speed * Time.deltaTime;          //”меньшаем значение слайдера до минимального
            if (slider.value == 0)          //≈сли значение слайдера на 0, то мен€ем направление
            {
                i = true;
            }
        }

        yield return new WaitForSeconds(0f);
        StartCoroutine(Scroll());
    }
}
