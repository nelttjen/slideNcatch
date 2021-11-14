using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteCube : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(CubeDestroy());          //��������� �������� �� �������� ����
    }

    IEnumerator CubeDestroy()
    {
        yield return new WaitForSeconds(12f);          //��� 10������
        Destroy(gameObject);          //������� ���
    }

    private void Update()
    {
        if (Time.timeScale == 0)          //���� � ���� � ���� ����������� ������ ���
        {
            Destroy(gameObject);
        }
    }
}
