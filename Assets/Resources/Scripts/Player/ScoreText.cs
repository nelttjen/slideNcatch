using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    private int max_score;
    private int current_score;
    public Text current_counter_score;
    public Text max_counter_score;
    public Text current_counter_score_text;
    public Text max_counter_score_text;

    private void Start()
    {
        //Загрузка сохраннёных очков
        current_score = PlayerPrefs.GetInt("Current_Score");
        max_score = PlayerPrefs.GetInt("Max_Score");
    }

    private void Score_counter()
    {
        //Установка рекорда очков
        if (current_score > max_score)
        {
            max_score = current_score;
            PlayerPrefs.SetInt("Max_Score", max_score);
        }
        //Текст очков во время игры
        current_counter_score.text = $"Score: {current_score}";
        max_counter_score.text = $"Best Score: {max_score}";
        //Текст очков после проигрыша
        current_counter_score_text.text = $"Score: {current_score}";
        max_counter_score_text.text = $"Best Score: {max_score}";
    }

    private void FixedUpdate()
    {
        current_score = PlayerPrefs.GetInt("Current_Score");
    }

    private void Update()
    {
        Score_counter();
    }
}
