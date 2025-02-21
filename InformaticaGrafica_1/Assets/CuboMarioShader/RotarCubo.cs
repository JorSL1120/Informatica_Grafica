using UnityEngine;

public class RotarCubo : MonoBehaviour
{
    public float SpeedRotation;

    void Update()
    {
        transform.Rotate(Vector3.up, SpeedRotation * Time.deltaTime);
        transform.Rotate(Vector3.right, SpeedRotation * Time.deltaTime);
        transform.Rotate(Vector3.forward, SpeedRotation * Time.deltaTime);
    }
}
