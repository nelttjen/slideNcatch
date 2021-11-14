using System.Collections;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    private float spawnPos_x;          //Позиция спавна кубов-монстров по Х
    private float spawnPosScore_x;          //Позиция спавна кубов-с-очками по Х
    public GameObject cube;
    public GameObject score_cube;
    private Vector3 spawnPos;
    private Vector3 spawnPosScore;
    private float rndEnemy;
    private float rndScore;

    private void FixedUpdate()
    {
        spawnPos_x = Random.Range(-1.5f, 1.5f);          //Выбор рандомной позиции по Х спавна кубов-монсров
        spawnPosScore_x = Random.Range(-1.5f, 1.5f);          //Выбор рандомной позиции по Х спавна кубов-с-очками
        spawnPos = new Vector3(spawnPos_x, 6f, 0);          //Позиция спавна кубов-монсров
        spawnPosScore = new Vector3(spawnPosScore_x, 7f, 0);          //Позиция спавна кубов-с-очками
    }

    private void Start()
    {
        rndEnemy = Random.Range(0.7f, 1.7f);
        rndScore = Random.Range(1.5f, 2.7f);

        StartCoroutine(SpawnCubeCD());          //Запускает куратину по спавну кубов-монстров
        StartCoroutine(SpawnScoreCube());          //Запускает куратину по спавну кубов-с-очками
    }

    void RepeatCD()          //Повторяет запуск куратины с кубами-монстрами
    {
        StartCoroutine(SpawnCubeCD());
    }

    void RepeatScore()          //Повтаряет запуск куратины с кубами-с-очками
    {
        StartCoroutine(SpawnScoreCube());
    }

    IEnumerator SpawnCubeCD()          //Куратина спавна кубов-монстров
    {
        yield return new WaitForSeconds(rndEnemy);
        rndEnemy = Random.Range(0.7f, 1.7f);
        Instantiate(cube, spawnPos, Quaternion.identity);
        RepeatCD();
    }

    IEnumerator SpawnScoreCube()          //Куратина спавна кубосв-с-очками
    {
        yield return new WaitForSeconds(rndScore);
        rndScore = Random.Range(1.5f, 2.7f);
        Instantiate(score_cube, spawnPosScore, Quaternion.identity);
        RepeatScore();
    }
}
