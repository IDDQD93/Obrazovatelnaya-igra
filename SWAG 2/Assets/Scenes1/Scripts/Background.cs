using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    [SerializeField] private Transform cameraTransform; // ������ �� ������
    [SerializeField] private float parallaxSpeed; // �������� ����������
    [SerializeField] private float backgroundWidth; // ������ ����

    private Transform[] backgroundParts; // ������ ��� �������� ������ ����
    private float startingPosition; // ��������� ��������� ����

    void Start()
    {
        // ������� ������ ��� �������� ������ ����
        backgroundParts = GetComponentsInChildren<Transform>();

        // ���������� ��������� ��������� ����
        startingPosition = transform.position.x;

        // ������������� ��������� ������� ��� ������ ����� ����
        for (int i = 1; i < backgroundParts.Length; i++)
        {
            backgroundParts[i].position = new Vector3(backgroundParts[i - 1].position.x + backgroundWidth,
                                                         backgroundParts[i - 1].position.y,
                                                         backgroundParts[i - 1].position.z);
        }
    }

    void Update()
    {
        // ��������� �������� ���� � ����������� �� ������� ������
        float parallaxX = (cameraTransform.position.x - startingPosition) * parallaxSpeed;

        // ������� ��� �� ��� X
        transform.position = new Vector3(startingPosition + parallaxX, transform.position.y, transform.position.z);

        // �������� � �������� ������ ����
        for (int i = 1; i < backgroundParts.Length; i++)
        {
            // ���� ����� ���� ������� �� ������� ������, 
            // �� ���������� �� � ������, ����� ��� �����������
            if (backgroundParts[i].position.x < cameraTransform.position.x - backgroundWidth)
            {
                backgroundParts[i].position = new Vector3(backgroundParts[i - 1].position.x + backgroundWidth,
                                                             backgroundParts[i - 1].position.y,
                                                             backgroundParts[i - 1].position.z);
            }
        }
    }
}