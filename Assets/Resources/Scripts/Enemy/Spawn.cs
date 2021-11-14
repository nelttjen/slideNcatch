using System.Collections;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    private float spawnPos_x;          //������� ������ �����-�������� �� �
    private float spawnPosScore_x;          //������� ������ �����-�-������ �� �
    public GameObject cube;
    public GameObject score_cube;
    private Vector3 spawnPos;
    private Vector3 spawnPosScore;
    private float rndEnemy;
    private float rndScore;

    private void FixedUpdate()
    {
        spawnPos_x = Random.Range(-1.5f, 1.5f);          //����� ��������� ������� �� � ������ �����-�������
        spawnPosScore_x = Random.Range(-1.5f, 1.5f);          //����� ��������� ������� �� � ������ �����-�-������
        spawnPos = new Vector3(spawnPos_x, 6f, 0);          //������� ������ �����-�������
        spawnPosScore = new Vector3(spawnPosScore_x, 7f, 0);          //������� ������ �����-�-������
    }

    private void Start()
    {
        rndEnemy = Random.Range(0.7f, 1.7f);
        rndScore = Random.Range(1.5f, 2.7f);

        StartCoroutine(SpawnCubeCD());          //��������� �������� �� ������ �����-��������
        StartCoroutine(SpawnScoreCube());          //��������� �������� �� ������ �����-�-������
    }

    void RepeatCD()          //��������� ������ �������� � ������-���������
    {
        StartCoroutine(SpawnCubeCD());
    }

    void RepeatScore()          //��������� ������ �������� � ������-�-������
    {
        StartCoroutine(SpawnScoreCube());
    }

    IEnumerator SpawnCubeCD()          //�������� ������ �����-��������
    {
        yield return new WaitForSeconds(rndEnemy);
        rndEnemy = Random.Range(0.7f, 1.7f);
        Instantiate(cube, spawnPos, Quaternion.identity);
        RepeatCD();
    }

    IEnumerator SpawnScoreCube()          //�������� ������ ������-�-������
    {
        yield return new WaitForSeconds(rndScore);
        rndScore = Random.Range(1.5f, 2.7f);
        Instantiate(score_cube, spawnPosScore, Quaternion.identity);
        RepeatScore();
    }
}
