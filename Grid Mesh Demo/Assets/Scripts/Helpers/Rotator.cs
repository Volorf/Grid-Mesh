using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private bool isLookingAt;
    [SerializeField] private Transform focusPoint;
    [SerializeField] private float rotSpeed = 1.0f;
    private float _rot = 0.0f;

    void Update()
    {
        if (isLookingAt) transform.LookAt(focusPoint);
        transform.RotateAround(focusPoint.position, Vector3.up, _rot);
        _rot = Time.deltaTime * rotSpeed;
    }
}
