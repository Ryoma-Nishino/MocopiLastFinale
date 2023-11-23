using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed = 2.0f; // �ړ����x
    public float maxDistance = 5.0f; // �ő�ړ�����

    private Vector3 startPosition;
    private Transform mainCamera;

    void Start()
    {
        // �����ʒu��ۑ�
        startPosition = transform.position;
        // ���C���J�������擾
        mainCamera = Camera.main.transform;
    }

    void Update()
    {
        // �J�����̍��E�����ɉ������铮��
        Vector3 direction = mainCamera.right * Mathf.Sin(Time.time * speed) * maxDistance;
        transform.position = startPosition + direction;
    }
}
