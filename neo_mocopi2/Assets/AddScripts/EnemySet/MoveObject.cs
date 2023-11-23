using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed = 2.0f; // 移動速度
    public float maxDistance = 5.0f; // 最大移動距離

    private Vector3 startPosition;
    private Transform mainCamera;

    void Start()
    {
        // 初期位置を保存
        startPosition = transform.position;
        // メインカメラを取得
        mainCamera = Camera.main.transform;
    }

    void Update()
    {
        // カメラの左右方向に往復する動き
        Vector3 direction = mainCamera.right * Mathf.Sin(Time.time * speed) * maxDistance;
        transform.position = startPosition + direction;
    }
}
