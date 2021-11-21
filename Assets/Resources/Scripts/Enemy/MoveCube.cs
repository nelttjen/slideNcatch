using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    private float RotateSpeed_Right;
    private float RotateSpeed_Left;
    private readonly float speed_y=-5;
    private float speed_x;
    GameObject fon;


    public GameObject cub;
    public int rnd;
    public int _rnd;

    private void Start()
    {
        RotateSpeed_Right = Random.Range(50, 200);          //Рандомная корость поворота против часовой
        RotateSpeed_Left = Random.Range(-50, -200);          //Рандомная скорость поворота по часовой
        rnd = Random.Range(-5, 5);          //Число для рандомного определения стороны полёта куба
        _rnd = Random.Range(-5, 5);          //Число для рандомного вращения круга
        if (rnd < 0)
        {
            speed_x = -2f;
        }
        else
        {
            speed_x = 2f;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            speed_x *= -1;
        }
    }

    private void Update()
    {
        if (_rnd <= 0)
        {
            transform.Rotate(0, 0, RotateSpeed_Right * Time.deltaTime);          //Кручение круга против часовой
        }
        else if (_rnd > 0)
        {
            transform.Rotate(0, 0, RotateSpeed_Left * Time.deltaTime);          //Кручение круга по часовой
        }
        cub.transform.Translate(speed_x * Time.deltaTime, speed_y * Time.deltaTime, 0);          //Перемещения куба в право или лево и вниз
    }
}
