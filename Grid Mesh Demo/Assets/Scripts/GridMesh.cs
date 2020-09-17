using UnityEngine;
using System.Collections.Generic;

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshCollider))]
public class GridMesh : MonoBehaviour
{
    [Space]  
    public int xSegments = 8;
    public int zSegments = 8;
    [Space]
    public float xStep = 1.0f;
    public float zStep = 1.0f;
    [Space]
    public Color color = Color.white;
    [Space]
    public bool centered = true;

    private float _xOffset = 0.0f;
    private float _zOffset = 0.0f;

    private readonly List<Vector3> _verticies = new List<Vector3>();
    private readonly List<int> _indicies = new List<int>();

    private MeshFilter _meshFilter;
    private Mesh _mesh;
    private MeshRenderer _meshRenderer;
    private MeshCollider _meshCollider;

    private void Awake()
    {
        if (centered)
        {
            _xOffset = xSegments * xStep / 2;
            _zOffset = zSegments * zStep / 2;
        }
        
        _mesh = new Mesh();
        _meshFilter = GetComponent<MeshFilter>();
        _meshRenderer = GetComponent<MeshRenderer>();
        _meshCollider = GetComponent<MeshCollider>();
    }

    private void Start()
    {
        GenerateVerts();
        GenerateIndicies();
        GenerateMesh();
        _meshCollider.sharedMesh = GenerateCollisionMesh();
    }

    private void GenerateVerts()
    {
        for (int z = 0; z <= zSegments; z++)
        {
            for (int x = 0; x <= xSegments; x++)
            {
                _verticies.Add(new Vector3(x * xStep - _xOffset, 0, z * zStep - _zOffset));
            }
        }
    }

    private Mesh GenerateCollisionMesh()
    {

        var mesh = new Mesh();

        Vector3[] points = 
        {
            new Vector3(0f - _xOffset, 0f, 0f - _zOffset),
            new Vector3(0f - _xOffset, 0f, zSegments * zStep - _zOffset),
            new Vector3(xSegments * xStep - _xOffset, 0f, 0f - _zOffset),
            new Vector3(xSegments * xStep - _xOffset, 0f, zSegments * zStep - _zOffset)
        };

        int[] indicies =
        {
            0, 1, 2, 2, 1, 3
        };

        mesh.Clear();
        mesh.name = "Collision Mesh";
        mesh.vertices = points;
        mesh.triangles = indicies;

        return mesh;
    }

    private void GenerateIndicies()
    {
        for (int vert = 0, z = 0; z < zSegments; z++)
        {
            for (int x = 0; x < xSegments; x++)
            {
                _indicies.Add(vert + 0);
                _indicies.Add(vert + 1 + xSegments);

                _indicies.Add(vert + 1 + xSegments);
                _indicies.Add(vert + 2 + xSegments);

                _indicies.Add(vert + 2 + xSegments);
                _indicies.Add(vert + 1);

                _indicies.Add(vert + 1);
                _indicies.Add(vert + 0);

                vert++;
            }
            vert++;
        }
    }
    
    private void GenerateMesh()
    {
        _mesh.Clear();
        _mesh.name = "Grid Mesh";
        _mesh.vertices = _verticies.ToArray();
        _mesh.SetIndices(_indicies, MeshTopology.Lines, 0);
        _meshFilter.mesh = _mesh;
        _meshRenderer.material = new Material(Shader.Find("Sprites/Default")) {color = color};
    }
}