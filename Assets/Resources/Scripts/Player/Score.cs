using System.Collections;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int current_score;
    private bool _shield = false;
    public GameObject FailMenu;
    public GameObject shield;
    public GameObject[] cubs;

    private void Start()
    {
        //����� ��������� ����� ����� � ������ ����
        current_score = PlayerPrefs.GetInt("Current_Score");
    }

    private void Update()
    {
        if (Time.timeScale == 0)          //��������� ���� ��������� ���� ����� � ���� �����������
        {
            FailMenu.SetActive(true);          //���������� ���� ���������
            StopAllCoroutines();          //����� ������������� ��� ��������
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Cube") && _shield == false)          //�������� �� ��������������� � �������� �����
        {
            Time.timeScale = 0;          //������������� ����� � ����
            StopAllCoroutines();          //������������� ��� ��������
        }

        if (collision.gameObject.CompareTag("Score"))
        {
            current_score++;
            PlayerPrefs.SetInt("Current_Score", current_score);
        }

        if (collision.gameObject.CompareTag("Cube_Shield"))
        {
            StartCoroutine(Shield());
        }
    }

    IEnumerator Shield()
    {
        _shield = true;
        shield.SetActive(true);
        yield return new WaitForSeconds(Random.Range(5f, 10f));
        _shield = false;
        shield.SetActive(false);
        StopCoroutine(Shield());
    }
}
