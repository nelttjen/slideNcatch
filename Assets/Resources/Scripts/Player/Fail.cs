using UnityEngine;

public class Fail : MonoBehaviour
{
    public GameObject FailMenu;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Cube"))          //Проверка на соприкосновение с крассным кубом
        {
            Time.timeScale = 0;          //Останавливает время в игре
            StopAllCoroutines();          //ОСтанавливает все куратины
        }
    }

    private void Update()
    {
        if (Time.timeScale == 0)          //Открывает меню проигрыша если время в игре остановлено
        {
            FailMenu.SetActive(true);          //Активирует менб проигрыша
            StopAllCoroutines();          //Опять останавливает все куратины
        }
    }
}
