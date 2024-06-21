using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformScript : MonoBehaviour
{
    public bool isCorrect; // ����, ������������, ����� �� ��������� �� ��������� �������
    public GameObject player; // ������ �� ������ ������

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            if (isCorrect)
            {
                // ������� �� ��������� �������
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else
            {
                // ������������ ������
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}