
using System.Collections;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject prefab;
    public GameObject target;
    public float interval = 1.0f;
    public float radius = 10.0f;
    public float speed = 1.0f;
    public float minAngle = -75.0f;
    public float maxAngle = 75.0f;
    public float minVerticalAngle = 90f;
    public float maxVerticalAngle = 180f;

    private int objectCount = 0;
    private int maxObjects = 10;
    private float elapsedTime = 0f;
    private float increaseTime = 0f; // maxObjects�𑝂₷���߂̌o�ߎ���
    private float Time3 = 0f;
    private float Add = 0f;
    private float Eternal = 0f;

    void Update()
    {
        elapsedTime += Time.deltaTime;
        increaseTime += Time.deltaTime;
        Eternal += Time.deltaTime;
        Add += Time.deltaTime;
        if(Eternal > 30f)
        {
            maxObjects += 100;
            Eternal -= Time.deltaTime;
        }

        if (increaseTime > 2.5f) // �o�߂�����
        {
            maxObjects++; // maxObjects�𑝂₷
            increaseTime = 0f; // �o�ߎ��Ԃ����Z�b�g
        }
        if(Add > 30.0f)
        {
            Time3 += Time.deltaTime;
            if (Time3 > 5.0f)
            {
                interval /= 2;
                Time3 = 0f;
            }
        }
        if (Time3 > 5.0f)
        {
            interval /= 2;
            Time3 = 0f;
        }

        if (elapsedTime > interval && objectCount < maxObjects)
        {
            Vector3 spawnPosition = GetSpawnPosition();
            Instantiate(prefab, spawnPosition, Quaternion.identity);
            objectCount++;
            elapsedTime = 0f;
        }
    }

    Vector3 GetSpawnPosition()
    {
        float angle = Random.Range(minAngle, maxAngle) * Mathf.Deg2Rad;
        float verticalAngle = Random.Range(minVerticalAngle, maxVerticalAngle) * Mathf.Deg2Rad;
        float x = radius * Mathf.Cos(angle) * Mathf.Sin(verticalAngle);
        float y = radius * Mathf.Cos(verticalAngle);
        float z = radius * Mathf.Sin(angle) * Mathf.Sin(verticalAngle);
        Vector3 spawnPosition = new Vector3(x, y, z);
        spawnPosition = target.transform.rotation * spawnPosition; // ��I�u�W�F�N�g�̉�]��K�p
        spawnPosition = spawnPosition + target.transform.position; // ��I�u�W�F�N�g�̈ʒu�����Z
        return spawnPosition;
    }
}
