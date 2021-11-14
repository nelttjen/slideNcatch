using UnityEngine;

public class Score : MonoBehaviour
{
    private int current_score;

    private void Start()
    {
        //����� ��������� ����� ����� � ������ ����
        current_score = PlayerPrefs.GetInt("Current_Score");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //�������� �� ��������������� � �������
        if (collision.gameObject.CompareTag("Player"))
        {
            //��������� ����, ��������� �����, ������� �����
            current_score++;
            PlayerPrefs.SetInt("Current_Score", current_score);
            Destroy(gameObject);
        }
    }
}
