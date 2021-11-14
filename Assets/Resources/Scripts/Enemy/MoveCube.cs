using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    private float RotateSpeed_Right;
    private float RotateSpeed_Left;
    private Vector2 direction;
    private readonly float speed_x = 0.025f;

    public GameObject cub;
    public int rnd;
    public int _rnd;

    private void Start()
    {
        RotateSpeed_Right = Random.Range(50, 200);          //Рандомная корость поворота против часовой
        RotateSpeed_Left = Random.Range(-50, -200);          //Рандомная скорость поворота по часовой
        rnd = Random.Range(-5, 5);          //Число для рандомного определения стороны полёта куба
        _rnd = Random.Range(-5, 5);          //Число для рандомного вращения круга
        if (rnd <= 0)
        { direction.x = -0.35f; }
        else
        { direction.x = 0.35f; }
        direction.y = -2f;
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
        cub.transform.Translate(direction * speed_x);          //Перемещения куба в право или лево и вниз
    }
}
