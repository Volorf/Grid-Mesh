using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloner : MonoBehaviour
{
    [SerializeField] private GameObject go;
    [SerializeField] private Vector3 axeCloning = new Vector3 (0f, 1f, 0f );
    [SerializeField] private int numberOfClones = 8;
    [SerializeField] private float step = 0.5f;
    void Start()
    {
        float offset = (float) numberOfClones / 2;
        if (!go) return;
        for (int i = 0; i < numberOfClones; i++)
        {
            Vector3 pos = new Vector3((offset - i) * step, (offset - i) * step, (offset - i) * step);
            pos.x *= axeCloning.x;
            pos.y *= axeCloning.y;
            pos.z *= axeCloning.z;
            Instantiate(go, pos, Quaternion.identity);
        }
        Destroy(go);
    }
}
