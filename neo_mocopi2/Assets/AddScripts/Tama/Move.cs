using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 3.0f;

    public GameObject otherObject; // ���̃I�u�W�F�N�g�ւ̎Q��

    void Start()
    {
        // �^�O���g���ăI�u�W�F�N�g������
        otherObject = GameObject.FindWithTag("Object");
    }

    void Update()
    {

        if (otherObject != null)
        {
            Vector3 direction = otherObject.transform.forward; // ���̃I�u�W�F�N�g��Z���������擾
            transform.Translate(direction * speed * Time.deltaTime);
        }

        // Z�������Ɉ��̑��x�œ�����
        //transform.Translate(0, 0, speed * Time.deltaTime);

        // ���̃I�u�W�F�N�g��Z�������Ɉ��̑��x�œ�����
        //Vector3 direction = otherObject.transform.forward; // ���̃I�u�W�F�N�g��Z���������擾
        //transform.Translate(direction * speed * Time.deltaTime);
    }
}
