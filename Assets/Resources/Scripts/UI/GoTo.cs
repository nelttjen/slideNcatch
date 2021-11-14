using UnityEngine;
using UnityEngine.SceneManagement;

public class GoTo : MonoBehaviour
{
    public GameObject FailMenu;
    private int current_score;

    public void GoToPlay()    //������� ��� ������ ����
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
        current_score = 0;
        PlayerPrefs.SetInt("Current_Score", current_score);
    }

    public void GoToShop()    //������� � �������
    {
        SceneManager.LoadScene(2);
    }

    public void GoToRecords()    //������� � ��������
    {
        SceneManager.LoadScene(3);
    }

    public void GoToMenu()    //������� � ������� ����
    {
        SceneManager.LoadScene(0);
    }
        
    public void GoToRestart()   //����������� ���� ����� ���������
    {
        current_score = 0;
        PlayerPrefs.SetInt("Current_Score", current_score);
        FailMenu.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
}
