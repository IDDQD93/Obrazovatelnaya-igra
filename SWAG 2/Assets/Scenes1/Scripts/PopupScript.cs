using UnityEngine;
using UnityEngine.UI;

public class PopupScript : MonoBehaviour
{
    public Text popupText; // ������ �� ��������� Text

    void Start()
    {
        // ���������� ����� � ���������� Text
        popupText.text = "������, ���!";
    }
}