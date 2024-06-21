using UnityEngine;
using UnityEngine.UI;

public class CanvasTrigger : MonoBehaviour
{
    public Canvas canvasToActivate; // Ссылка на Canvas, который нужно активировать

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Проверка, соприкоснулся ли игрок с платформой
        if (collision.gameObject.CompareTag("Player"))
        {
            // Активируем Canvas
            canvasToActivate.gameObject.SetActive(true);
        }
    }
}