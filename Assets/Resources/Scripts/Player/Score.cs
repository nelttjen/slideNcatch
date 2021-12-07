using System.Collections;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int current_score;
    public static bool _shield = false;
    private int count = 0;
    private int rnd;
    public GameObject Circle;
    public GameObject particle;
    public GameObject FailMenu;
    public GameObject shield;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
        anim.speed = 0;
        anim.Play("ScoreAnim");
        current_score = PlayerPrefs.GetInt("Current_Score");
        rnd = Random.Range(0, 9);
    }

    private void Update()
    {
        if (Time.timeScale == 0)          //ќткрывает меню проигрыша если врем€ в игре остановлено
        {
            FailMenu.SetActive(true);          //јктивирует меню проигрыша
            StopAllCoroutines();          //ќп€ть останавливает все куратины
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Cube") && _shield == false)          //ѕроверка на соприкосновение с крассным кубом
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.clear;
            Destroy(Circle);
            StartPartic();
        }
        if (collision.gameObject.CompareTag("Cube") && _shield == true)          //ѕроверка на соприкосновение с крассным кубом
        {
            
        }

        if (collision.gameObject.CompareTag("Score"))
        {
            current_score++;
            PlayerPrefs.SetInt("Current_Score", current_score);
            StartCoroutine(AnimationScore());
        }

        if (collision.gameObject.CompareTag("Cube_Shield"))
        {
            StartCoroutine(Shield());
        }
    }

    IEnumerator AnimationScore()
    {
        anim.Play("ScoreAnim");
        anim.speed = 1f;
        yield return new WaitForSeconds(1f);
        anim.speed = 0f;
        StopCoroutine(AnimationScore());
    }

    IEnumerator Shield()
    {
        _shield = true;
        shield.SetActive(true);
        yield return new WaitForSeconds(Random.Range(6f, 10f));
        _shield = false;
        shield.SetActive(false);
        StopCoroutine(Shield());
    }

    #region ѕартиклы при смерти
    private void StartPartic()
    {
        StartCoroutine(Partic());
    }
    IEnumerator Partic()
    {
        Time.timeScale = 0.3f;
        Instantiate(particle, transform.position, Quaternion.identity);
        count++;
        yield return new WaitForSeconds(0.05f);
        if (count == 30)
        {
            Time.timeScale = 0;
            StopAllCoroutines();
        }
        else
        {
            StartPartic();
        }
    }
    #endregion
}