using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public float rnd;
    public GameObject cube;
    public Vector3 spawnPos;
    public GameObject cube_2;
    public Vector3 spawnPos_2;

    private void FixedUpdate()
    {
        rnd = Random.Range(-3.5f, 3.5f);
        spawnPos = new Vector3(rnd, 5.5f, 0);
        spawnPos_2 = new Vector3(rnd, 5.5f, 0);
    }

    private void Start()
    {
        StartCoroutine(SpawnCd());
    }

    void Repeat()
    {
        StartCoroutine(SpawnCd());
    }

    IEnumerator SpawnCd()
    {
        yield return new WaitForSeconds(1f);
        Instantiate(cube, spawnPos, Quaternion.identity);
        Repeat();
    }
}
