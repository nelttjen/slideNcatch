using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteCube : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(CubeDestroy());          //Запускает куратину на удаление куба
    }

    IEnumerator CubeDestroy()
    {
        yield return new WaitForSeconds(12f);          //Ждёт 10секунд
        Destroy(gameObject);          //Удаляет куб
    }

    private void Update()
    {
        if (Time.timeScale == 0)          //Если в ремя в игре остановлено удалит куб
        {
            Destroy(gameObject);
        }
    }
}
