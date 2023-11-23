using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour
{
    public Transform targetObject; // 追跡対象のオブジェクト

    void LateUpdate()
    {
        if (targetObject != null)
        {
            // MixedRealityPlayspaceの位置をtargetObjectの位置に更新
            transform.position = targetObject.position;
        }
    }
}
