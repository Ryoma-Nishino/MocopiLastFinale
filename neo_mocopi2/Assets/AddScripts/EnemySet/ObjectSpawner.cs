using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn; // 生成するオブジェクト
    public GameObject centerObject; // 中心となるオブジェクト
    public float radius = 10f; // 球体の半径
    private float timeCounter = 0f; // 時間計測用のカウンター

    void Start()
    {

    }

    void Update()
    {
        timeCounter += Time.deltaTime; // 経過時間を加算
        if (timeCounter >= 1f) // 1秒以上経過したら
        {
            SpawnObject(); // オブジェクトを生成
            timeCounter = 0f; // カウンターをリセット
        }
    }

    void SpawnObject()
    {
        Vector3 centerPosition = centerObject.transform.position; // 中心となるオブジェクトの位置

        // ランダムな角度を生成
        float verticalAngle = Random.Range(75f, 90f);
        float horizontalAngle = Random.Range(0f, 150f);

        // 球座標系を直交座標系に変換
        float x = radius * Mathf.Sin(verticalAngle * Mathf.Deg2Rad) * Mathf.Cos(horizontalAngle * Mathf.Deg2Rad);
        float y = radius * Mathf.Cos(verticalAngle * Mathf.Deg2Rad);
        float z = radius * Mathf.Sin(verticalAngle * Mathf.Deg2Rad) * Mathf.Sin(horizontalAngle * Mathf.Deg2Rad);

        Vector3 spawnPosition = new Vector3(x, y, z) + centerPosition; // 生成位置を計算

        Instantiate(objectToSpawn, spawnPosition, Quaternion.identity); // オブジェクトを生成
    }
}
