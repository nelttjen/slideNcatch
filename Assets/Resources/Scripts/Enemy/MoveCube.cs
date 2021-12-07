using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    private float RotateSpeed_Right;
    private float RotateSpeed_Left;
    private readonly float speed_y=-4.5f;
    private float speed_x;


    public GameObject cub;
    public float rnd;
    public float _rnd;

    private void Start()
    {
        RotateSpeed_Right = Random.Range(50, 200);          //Рандомная корость поворота против часовой
        RotateSpeed_Left = Random.Range(-50, -200);          //Рандомная скорость поворота по часовой
        rnd = Random.Range(-1.5f, 2.6f);          //Число для рандомного определения стороны полёта куба
        _rnd = Random.Range(5.0f, 5.1f);          //Число для рандомного вращения круга
        if (rnd < 0)
        {
            speed_x = rnd;
        }
        else
        {
            speed_x = rnd;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
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
