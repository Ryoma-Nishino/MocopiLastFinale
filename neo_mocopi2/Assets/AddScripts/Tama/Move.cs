using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 3.0f;

    public GameObject otherObject; // 他のオブジェクトへの参照

    void Start()
    {
        // タグを使ってオブジェクトを検索
        otherObject = GameObject.FindWithTag("Object");
    }

    void Update()
    {

        if (otherObject != null)
        {
            Vector3 direction = otherObject.transform.forward; // 他のオブジェクトのZ軸方向を取得
            transform.Translate(direction * speed * Time.deltaTime);
        }

        // Z軸方向に一定の速度で動かす
        //transform.Translate(0, 0, speed * Time.deltaTime);

        // 他のオブジェクトのZ軸方向に一定の速度で動かす
        //Vector3 direction = otherObject.transform.forward; // 他のオブジェクトのZ軸方向を取得
        //transform.Translate(direction * speed * Time.deltaTime);
    }
}
