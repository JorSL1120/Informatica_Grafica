using UnityEngine;


[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]

public class Triangulo : MonoBehaviour
{
    public Material material;

    void Start()
    {
        CreateTrian();
    }

    private void CreateTrian()
    {
        Vector3[] vertices =
        {
            new Vector3 (0, 0, 0), //0
            new Vector3 (1, 0, 0), //1
            new Vector3 (0.5f, 1, 0.5f), //2
            new Vector3 (0.5f, 0, 1) //3
        };

        int[] triangles =
        {
            0, 2, 1, //face front
            1, 2, 3, //right face
            3, 2, 0, //left face
            3, 0, 1 //down face
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
