using UnityEngine;
using UnityEngine.SceneManagement;

public class GoTo : MonoBehaviour
{
    public GameObject FailMenu;
    private int current_score;

    public void GoToPlay()    //Функция для начала игры
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
        current_score = 0;
        PlayerPrefs.SetInt("Current_Score", current_score);
    }

    public void GoToShop()    //Переход в магазин
    {
        SceneManager.LoadScene(2);
    }

    public void GoToRecords()    //Переход к рекордам
    {
        SceneManager.LoadScene(3);
    }

    public void GoToMenu()    //Переход в главное меню
    {
        SceneManager.LoadScene(0);
    }
        
    public void GoToRestart()   //Рестартнуть игру после проигрыша
    {
        current_score = 0;
        PlayerPrefs.SetInt("Current_Score", current_score);
        FailMenu.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
}
