using UnityEngine;
using UnityEngine.UI;

public class PopupScript : MonoBehaviour
{
    public Text popupText; // Ссылка на компонент Text

    void Start()
    {
        // Установите текст в компоненте Text
        popupText.text = "Привет, мир!";
    }
}