using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scrolling : MonoBehaviour
{
    public float speed = 0.5f;

    public void Click()          //Метод для смены направления при клике
    {
        speed *= -1;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("SliderWall"))
        {
            speed *= -1;
        }
    }

    private void Update()
    {
        transform.Translate(speed*Time.deltaTime, 0, 0);
    }
}
