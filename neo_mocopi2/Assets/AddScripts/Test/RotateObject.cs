using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotateSpeed = 50f; // ‰ñ“]‘¬“x

    void Update()
    {
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
    }
}
