using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scrolling : MonoBehaviour
{
    public float speed = 3f;
    private float x;

    public void Click()          //Метод для смены направления при клике
    {
        if (-1.9 < x && x < 1.9)
        {
            speed *= -1;
        }
        new WaitForSeconds(0.2f);
    }

    private void Update()
    {
        x = transform.position.x;

        transform.Translate(speed * Time.deltaTime, 0, 0);
        if (x > 1.9f && speed > 0 || x < -1.9f && speed < 0)
        {
            speed *= -1;
        }
    }
}