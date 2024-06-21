using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    // Окошко диалога
    public Image dialogWindow;
    public Text dialogText;

    // Метод, который вызывается при неправильном выборе ответа
    public void ShowWrongAnswerDialog()
    {
        // Отображаем окошко диалога
        dialogWindow.gameObject.SetActive(true);
        dialogText.text = "Неправильный ответ!";
    }
}
