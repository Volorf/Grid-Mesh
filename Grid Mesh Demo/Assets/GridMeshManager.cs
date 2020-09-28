using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMeshManager : MonoBehaviour
{
    public Material gridMat;
    private GridMesh _gridMesh;

    private void Awake() 
    {
        // Get GridMesh component
        _gridMesh = GetComponent<GridMesh>();
        // How many cell you will get on the X axis
        _gridMesh.xSegments = 8;
        // How many cell you will get on the Y axis
        _gridMesh.ySegments = 16;
        // Cell width
        _gridMesh.xStep = 1f;
        // Cell height
        _gridMesh.yStep = 0.5f;
        // Sets a material. By default it's magenta
        _gridMesh.material = gridMat;
        // Centers the grid to the game object
        _gridMesh.isCentered = true;
    }
}
