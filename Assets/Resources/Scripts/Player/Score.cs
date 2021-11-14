using UnityEngine;

public class Score : MonoBehaviour
{
    private int current_score;

    private void Start()
    {
        //Задаём начальное число очков в начале игры
        current_score = PlayerPrefs.GetInt("Current_Score");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Проверка на соприкосновение с игроком
        if (collision.gameObject.CompareTag("Player"))
        {
            //Добавляем очки, сохраняем число, удаляем кубик
            current_score++;
            PlayerPrefs.SetInt("Current_Score", current_score);
            Destroy(gameObject);
        }
    }
}
