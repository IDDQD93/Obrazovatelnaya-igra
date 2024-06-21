using UnityEngine;
using UnityEngine.UI;

public class CanvasTrigger : MonoBehaviour
{
    public Canvas canvasToActivate; // ������ �� Canvas, ������� ����� ������������

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // ��������, ������������� �� ����� � ����������
        if (collision.gameObject.CompareTag("Player"))
        {
            // ���������� Canvas
            canvasToActivate.gameObject.SetActive(true);
        }
    }
}