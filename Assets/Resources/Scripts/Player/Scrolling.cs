using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scrolling : MonoBehaviour
{
    public float speed = 2f;
    private float x;

    public void Click()          //Метод для смены направления при клике
    {
        speed *= -1;
        new WaitForSeconds(0.2f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("SliderWall"))
        {
            if (x > 1.9f || x < -1.9f)
            {
                speed *= -1;
            }
        }
    }

    private void Update()
    {
        x = transform.position.x;

        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}