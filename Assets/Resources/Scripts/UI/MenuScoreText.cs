using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScoreText : MonoBehaviour
{
    //[SerializeField]
    //private readonly GameObject bestScore = GameObject.Find("Best_score");
    private int max_score;
    public Text max_counter_score;

    //public string[] score = new string[5];
    //private int n = 0;

    private void Start()
    {
        max_score = PlayerPrefs.GetInt("Max_Score");
        max_counter_score.text = $"Best Score: {max_score}";

        //while (n < score.Length)
        //{
        //    Instantiate(bestScore, bestScore.transform.position, Quaternion.identity);

        //    n++;
        //}
    }
}