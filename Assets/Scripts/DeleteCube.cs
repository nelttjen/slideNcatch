using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteCube : MonoBehaviour
{
    private float m_RotateSpeed;
    private Vector2 direction;
    private Vector2 direct;
    private float speed = 0.01f;
    private float speed_2 = 0.013f;
    public GameObject cub;

    private void Start()
    {
        m_RotateSpeed = Random.Range(50, 200);
        direction.x = Random.Range(-1, 1);
        direct.y = -1;
        direct.x = 0;
    }

    void FixedUpdate()
    {
        transform.Rotate(0, 0, m_RotateSpeed * Time.deltaTime);
    }

    private void Update()
    {
        cub.transform.Translate(direction.normalized * speed);
        cub.transform.Translate(direct.normalized * speed_2);
    }

    IEnumerator CubeDestroy()
    {
        yield return new WaitForSeconds(5f);
        Destroy(cub);
    }
}
