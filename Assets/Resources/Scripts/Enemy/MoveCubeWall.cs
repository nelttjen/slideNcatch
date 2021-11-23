using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCubeWall : MonoBehaviour
{
    private float RotateSpeed_Right;
    private float RotateSpeed_Left;
    private readonly float speed_y = -4.5f;
    private float speed_x;

    public GameObject cub;
    public float rnd;
    public int _rnd;

    private void Start()
    {
        RotateSpeed_Right = Random.Range(50, 200);
        RotateSpeed_Left = Random.Range(-50, -200);
        rnd = Random.Range(-2.0f, 3.0f);
        _rnd = Random.Range(-5, 5);
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
        if (collision.gameObject.CompareTag("Wall"))
        {
            speed_x *= -1;
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (_rnd < 0)
        {
            transform.Rotate(0, 0, RotateSpeed_Right * Time.deltaTime);
        }
        else
        {
            transform.Rotate(0, 0, RotateSpeed_Left * Time.deltaTime);
        }
        cub.transform.Translate(speed_x * Time.deltaTime, speed_y * Time.deltaTime, 0);
    }
}
