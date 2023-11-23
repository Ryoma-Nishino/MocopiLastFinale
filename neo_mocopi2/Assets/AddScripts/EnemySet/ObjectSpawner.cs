using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn; // ��������I�u�W�F�N�g
    public GameObject centerObject; // ���S�ƂȂ�I�u�W�F�N�g
    public float radius = 10f; // ���̂̔��a
    private float timeCounter = 0f; // ���Ԍv���p�̃J�E���^�[

    void Start()
    {

    }

    void Update()
    {
        timeCounter += Time.deltaTime; // �o�ߎ��Ԃ����Z
        if (timeCounter >= 1f) // 1�b�ȏ�o�߂�����
        {
            SpawnObject(); // �I�u�W�F�N�g�𐶐�
            timeCounter = 0f; // �J�E���^�[�����Z�b�g
        }
    }

    void SpawnObject()
    {
        Vector3 centerPosition = centerObject.transform.position; // ���S�ƂȂ�I�u�W�F�N�g�̈ʒu

        // �����_���Ȋp�x�𐶐�
        float verticalAngle = Random.Range(75f, 90f);
        float horizontalAngle = Random.Range(0f, 150f);

        // �����W�n�𒼌����W�n�ɕϊ�
        float x = radius * Mathf.Sin(verticalAngle * Mathf.Deg2Rad) * Mathf.Cos(horizontalAngle * Mathf.Deg2Rad);
        float y = radius * Mathf.Cos(verticalAngle * Mathf.Deg2Rad);
        float z = radius * Mathf.Sin(verticalAngle * Mathf.Deg2Rad) * Mathf.Sin(horizontalAngle * Mathf.Deg2Rad);

        Vector3 spawnPosition = new Vector3(x, y, z) + centerPosition; // �����ʒu���v�Z

        Instantiate(objectToSpawn, spawnPosition, Quaternion.identity); // �I�u�W�F�N�g�𐶐�
    }
}
