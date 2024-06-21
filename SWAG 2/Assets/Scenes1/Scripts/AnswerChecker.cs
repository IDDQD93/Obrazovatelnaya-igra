using UnityEngine;

public class AnswerChecker : MonoBehaviour
{
    public Transform correctPlatform; // ���������, ������� �� ��������� �������
    public Transform wrongPlatform; // ���������, ������� � �������

    public void CheckAnswer(string playerAnswer, string correctAnswer)
    {
        if (playerAnswer == correctAnswer)
        {
            // ����������� ������ �� ���������� ���������
            transform.position = correctPlatform.position;
        }
        else
        {
            // ����������� ������ �� ������������ ���������
            transform.position = wrongPlatform.position;
        }
    }
}
