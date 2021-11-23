using System.Collections;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    private float spawnPos_x;          //������� ������ �����-�������� �� �
    private float spawnPosScore_x;          //������� ������ �����-�-������ �� �
    public GameObject[] mass_Cube;
    private Vector3 spawnPos;
    private Vector3 spawnPosScore;

    private void FixedUpdate()
    {
        spawnPos_x = Random.Range(-1.5f, 1.5f);          //����� ��������� ������� �� � ������ �����-�������
        spawnPosScore_x = Random.Range(-1.5f, 1.5f);          //����� ��������� ������� �� � ������ �����-�-������
        spawnPos = new Vector3(spawnPos_x, 6f, 0);          //������� ������ �����-�������
        spawnPosScore = new Vector3(spawnPosScore_x, 7f, 0);          //������� ������ �����-�-������
    }

    private void Start()
    {
        StartCoroutine(SpawnCubeCD());          //��������� �������� �� ������ �����-��������
        StartCoroutine(SpawnScoreCube());          //��������� �������� �� ������ �����-�-������
        StartCoroutine(SpawnWallCube());
        StartCoroutine(SpawnShieldCube());
    }

    void RepeatCD()          //��������� ������ �������� � ������-���������
    {
        StartCoroutine(SpawnCubeCD());
    }
    IEnumerator SpawnCubeCD()          //�������� ������ �����-��������
    {
        yield return new WaitForSeconds(Random.Range(0.7f, 1.7f));
        Instantiate(mass_Cube[0], spawnPos, Quaternion.identity);
        RepeatCD();
    }

    void RepeatScore()          //��������� ������ �������� � ������-�-������
    {
        StartCoroutine(SpawnScoreCube());
    }
    IEnumerator SpawnScoreCube()          //�������� ������ ������-�-������
    {
        yield return new WaitForSeconds(Random.Range(1.5f, 2.7f));
        Instantiate(mass_Cube[1], spawnPosScore, Quaternion.identity);
        RepeatScore();
    }

    void RepeatWall()
    {
        StartCoroutine(SpawnWallCube());
    }
    IEnumerator SpawnWallCube()
    {
        yield return new WaitForSeconds(Random.Range(3.7f, 6.7f));
        Instantiate(mass_Cube[2], spawnPosScore, Quaternion.identity);
        RepeatWall();
    }

    void RepeatShield()
    {
        StartCoroutine(SpawnShieldCube());
    }
    IEnumerator SpawnShieldCube()
    {
        yield return new WaitForSeconds(Random.Range(12.0f, 25.0f));
        Instantiate(mass_Cube[3], spawnPosScore, Quaternion.identity);
        RepeatShield();
    }
}
