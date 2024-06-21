using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    [SerializeField] private Transform cameraTransform; // Ссылка на камеру
    [SerializeField] private float parallaxSpeed; // Скорость параллакса
    [SerializeField] private float backgroundWidth; // Ширина фона

    private Transform[] backgroundParts; // Массив для хранения частей фона
    private float startingPosition; // Начальное положение фона

    void Start()
    {
        // Создаем массив для хранения частей фона
        backgroundParts = GetComponentsInChildren<Transform>();

        // Запоминаем начальное положение фона
        startingPosition = transform.position.x;

        // Устанавливаем начальную позицию для каждой части фона
        for (int i = 1; i < backgroundParts.Length; i++)
        {
            backgroundParts[i].position = new Vector3(backgroundParts[i - 1].position.x + backgroundWidth,
                                                         backgroundParts[i - 1].position.y,
                                                         backgroundParts[i - 1].position.z);
        }
    }

    void Update()
    {
        // Вычисляем смещение фона в зависимости от позиции камеры
        float parallaxX = (cameraTransform.position.x - startingPosition) * parallaxSpeed;

        // Смещаем фон по оси X
        transform.position = new Vector3(startingPosition + parallaxX, transform.position.y, transform.position.z);

        // Проверка и смещение частей фона
        for (int i = 1; i < backgroundParts.Length; i++)
        {
            // Если часть фона выходит за пределы экрана, 
            // то перемещаем ее в начало, чтобы она повторилась
            if (backgroundParts[i].position.x < cameraTransform.position.x - backgroundWidth)
            {
                backgroundParts[i].position = new Vector3(backgroundParts[i - 1].position.x + backgroundWidth,
                                                             backgroundParts[i - 1].position.y,
                                                             backgroundParts[i - 1].position.z);
            }
        }
    }
}