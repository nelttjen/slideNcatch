using System.Collections;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    private float spawnPos_x;          //Позиция спавна кубов-монстров по Х
    private float spawnPosScore_x;          //Позиция спавна кубов-с-очками по Х
    public GameObject[] mass_Cube;
    private Vector3 spawnPos;
    private Vector3 spawnPosScore;

    private void FixedUpdate()
    {
        spawnPos_x = Random.Range(-1.5f, 1.5f);          //Выбор рандомной позиции по Х спавна кубов-монсров
        spawnPosScore_x = Random.Range(-1.5f, 1.5f);          //Выбор рандомной позиции по Х спавна кубов-с-очками
        spawnPos = new Vector3(spawnPos_x, 6f, 0);          //Позиция спавна кубов-монсров
        spawnPosScore = new Vector3(spawnPosScore_x, 7f, 0);          //Позиция спавна кубов-с-очками
    }

    private void Start()
    {
        StartCoroutine(SpawnCubeCD());          //Запускает куратину по спавну кубов-монстров
        StartCoroutine(SpawnScoreCube());          //Запускает куратину по спавну кубов-с-очками
        StartCoroutine(SpawnWallCube());
        StartCoroutine(SpawnShieldCube());
    }

    void RepeatCD()          //Повторяет запуск куратины с кубами-монстрами
    {
        StartCoroutine(SpawnCubeCD());
    }
    IEnumerator SpawnCubeCD()          //Куратина спавна кубов-монстров
    {
        yield return new WaitForSeconds(Random.Range(1f, 2f));
        Instantiate(mass_Cube[0], spawnPos, Quaternion.identity);
        RepeatCD();
    }

    void RepeatScore()          //Повтаряет запуск куратины с кубами-с-очками
    {
        StartCoroutine(SpawnScoreCube());
    }
    IEnumerator SpawnScoreCube()          //Куратина спавна кубосв-с-очками
    {
        yield return new WaitForSeconds(Random.Range(2f, 3f));
        Instantiate(mass_Cube[1], spawnPosScore, Quaternion.identity);
        RepeatScore();
    }

    void RepeatWall()
    {
        StartCoroutine(SpawnWallCube());
    }
    IEnumerator SpawnWallCube()
    {
        yield return new WaitForSeconds(Random.Range(4f, 7f));
        Instantiate(mass_Cube[2], spawnPos, Quaternion.identity);
        RepeatWall();
    }

    void RepeatShield()
    {
        StartCoroutine(SpawnShieldCube());
    }
    IEnumerator SpawnShieldCube()
    {
        yield return new WaitForSeconds(Random.Range(12.0f, 22.0f));
        Instantiate(mass_Cube[3], spawnPosScore, Quaternion.identity);
        RepeatShield();
    }
}
