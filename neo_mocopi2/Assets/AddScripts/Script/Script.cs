using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    [SerializeField]
	[Tooltip("発生させるエフェクト(パーティクル)")]
	public GameObject particleObject;
    private GameObject effect;

    [SerializeField]
    [Tooltip("生成する新しいオブジェクトのプレハブ")]
    public GameObject newObjectPrefab; // 新しいオブジェクトのプレハブ

    private GameObject newObject; // 新しいオブジェクトのインスタンス
    //GameObject effect = Instantiate(particleObject);

    void Start(){
        
    }

    void Update(){
        
    }

    //OnCollisionEnter/stay関数
    private void OnCollisionEnter(Collision collision){
 
        
        if (collision.gameObject.tag == "Object"){
            Debug.Log("hit");

            // パーティクルシステムのインスタンスを生成する。
            /*if (effect == null)
            {
                effect = Instantiate(particleObject);
                effect.transform.position = this.transform.position;
                InvokeRepeating("CreateNewObject", 0.5f, 0.5f);
            }*/
            effect = Instantiate(particleObject);
            effect.transform.position = this.transform.position;

            InvokeRepeating("CreateNewObject", 0.1f, 0.1f);
            //InvokeRepeating("CreateNewObject", 0.5f, 0.5f);
            //Destroy(effect,6);
        }
    }
    private void OnCollisionExit(Collision collision){
        if(collision.gameObject.tag == "Object"){
            Debug.Log("wwww");
            Destroy(effect);
            //effect = null;

            CancelInvoke("CreateNewObject");
        }
    }

    void CreateNewObject()
    {
        // 新しいオブジェクトのインスタンスを生成する。
        newObject = Instantiate(newObjectPrefab);
        newObject.transform.position = this.transform.position;

        // r_Cubeという名前のオブジェクトを見つける
        GameObject parentObject = GameObject.Find("r_Cube");

        // 見つけたオブジェクトを親として設定する
        /*if (parentObject != null)
        {
            newObject.transform.parent = parentObject.transform;
        }
        else
        {
            Debug.Log("r_Cubeという名前のオブジェクトが見つかりませんでした。");
        }

        // 0.1秒後に親子関係を解消する
        Invoke("DetachFromParent", 0.1f);*/

        // 2秒後に新しいオブジェクトを破棄する
        Destroy(newObject, 2f);
    }

    void DetachFromParent()
    {
        if (newObject != null)
        {
            newObject.transform.parent = null;
        }
    }
}
