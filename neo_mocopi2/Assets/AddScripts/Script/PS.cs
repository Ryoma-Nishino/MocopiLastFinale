using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour
{
    private GameObject _parent;
    // Start is called before the first frame update
    void Start()
    {
        //子から親を取得
        _parent = transform.root.gameObject;
        Debug.Log("Parent:" + _parent.name);
        //親子関係構築
        transform.parent = GameObject.FindWithTag("Object").transform;
        //transform.parent = GameObject.Find("Cube1").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /**private void OnParticleCollision(gameObject other){
        /// <summary>
	    /// パーティクルが他のGameObject(Collider)に当たると呼び出される
	    /// </summary>
	    /// <param name="other"></param>
        //Destroy();
        other.gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV();
    }**/
}
