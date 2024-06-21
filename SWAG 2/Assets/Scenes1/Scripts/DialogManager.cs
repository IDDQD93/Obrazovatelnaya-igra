using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    // ������ �������
    public Image dialogWindow;
    public Text dialogText;

    // �����, ������� ���������� ��� ������������ ������ ������
    public void ShowWrongAnswerDialog()
    {
        // ���������� ������ �������
        dialogWindow.gameObject.SetActive(true);
        dialogText.text = "������������ �����!";
    }
}
