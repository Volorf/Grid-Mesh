using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 dir = Vector3.forward;
    [SerializeField] private float speed = 0.5f;
    
    private void Update()
    {
        transform.Translate(dir * (Time.deltaTime * speed));
    }
}
