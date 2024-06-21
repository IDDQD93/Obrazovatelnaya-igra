using UnityEngine;
using UnityEngine.UI;

public class CloseButton : MonoBehaviour
{
    public Image imageToClose; // —сылка на Image, который нужно закрыть

    public void CloseImage()
    {
        // ќтключаем видимость Image
        imageToClose.gameObject.SetActive(false);
    }
}