using UnityEngine;

public class Fail : MonoBehaviour
{
    public GameObject FailMenu;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Cube"))          //�������� �� ��������������� � �������� �����
        {
            Time.timeScale = 0;          //������������� ����� � ����
            StopAllCoroutines();          //������������� ��� ��������
        }
    }

    private void Update()
    {
        if (Time.timeScale == 0)          //��������� ���� ��������� ���� ����� � ���� �����������
        {
            FailMenu.SetActive(true);          //���������� ���� ���������
            StopAllCoroutines();          //����� ������������� ��� ��������
        }
    }
}
