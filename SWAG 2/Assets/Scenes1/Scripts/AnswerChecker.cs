using UnityEngine;

public class AnswerChecker : MonoBehaviour
{
    public Transform correctPlatform; // Платформа, ведущая на следующий уровень
    public Transform wrongPlatform; // Платформа, ведущая к неудаче

    public void CheckAnswer(string playerAnswer, string correctAnswer)
    {
        if (playerAnswer == correctAnswer)
        {
            // Перемещение игрока на правильную платформу
            transform.position = correctPlatform.position;
        }
        else
        {
            // Перемещение игрока на неправильную платформу
            transform.position = wrongPlatform.position;
        }
    }
}
