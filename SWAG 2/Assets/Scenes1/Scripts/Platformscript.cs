using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformScript : MonoBehaviour
{
    public bool isCorrect; // ‘лаг, определ€ющий, ведет ли платформа на следующий уровень
    public GameObject player; // —сылка на объект игрока

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            if (isCorrect)
            {
                // ѕереход на следующий уровень
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else
            {
                // ѕерезагрузка уровн€
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}