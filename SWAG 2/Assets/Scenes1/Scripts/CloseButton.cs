using UnityEngine;
using UnityEngine.UI;

public class CloseButton : MonoBehaviour
{
    public Image imageToClose; // ������ �� Image, ������� ����� �������

    public void CloseImage()
    {
        // ��������� ��������� Image
        imageToClose.gameObject.SetActive(false);
    }
}