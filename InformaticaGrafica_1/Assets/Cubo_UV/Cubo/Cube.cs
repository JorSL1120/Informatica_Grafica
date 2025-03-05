using UnityEngine;
using System.Collections.Generic;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]

public class Cube : MonoBehaviour
{
    public Material material;

    void Start()
    {
        CreateCube();
    }

    private void CreateCube()
    {
        Vector3[] vertices =
        {
            new Vector3 (0, 0, 0), //0
            new Vector3 (1, 0, 0), //1
            new Vector3 (1, 1, 0), //2
            new Vector3 (0, 1, 0), //3
            new Vector3 (0, 1, 1), //4
            new Vector3 (1, 1, 1), //5
            new Vector3 (1, 0, 1), //6
            new Vector3 (0, 0, 1) //7
        };

        int[] triangles =
        {
            0, 2, 1, //face front
            0, 3, 2,
            1, 5, 6, //right face
            1, 2, 5,
            6, 4, 7, //back face
            6, 5, 4,
            7, 3, 0, //left face
            7, 4, 3,
            3, 5, 2, // up face
            3, 4, 5,
            7, 1, 6, //down face
            7, 0, 1
        };


        Mesh mesh = GetComponent<MeshFilter>().mesh;
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        meshRenderer.material = material;
        mesh.Optimize();
        mesh.RecalculateNormals();
    }

}
