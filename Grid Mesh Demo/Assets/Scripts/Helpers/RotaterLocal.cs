using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotaterLocal : MonoBehaviour
{
    [SerializeField] private Vector3 dir = Vector3.forward;
    [SerializeField] private float speed = 10f;
    
    void Update()
    {
        transform.Rotate(dir, Time.deltaTime * speed);
    }
}
