using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour
{
    public Transform targetObject; // �ǐՑΏۂ̃I�u�W�F�N�g

    void LateUpdate()
    {
        if (targetObject != null)
        {
            // MixedRealityPlayspace�̈ʒu��targetObject�̈ʒu�ɍX�V
            transform.position = targetObject.position;
        }
    }
}
