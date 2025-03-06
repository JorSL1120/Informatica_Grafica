using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]

public class Dado20 : MonoBehaviour
{
    public Material material;

    void Start()
    {
        CreateDado();
    }

    private void CreateDado()
    {
        // Nuevos vértices proporcionados
        Vector3[] vertices = {
            new Vector3(0.00f, 0.01f, -24.54f), // Coord1
            new Vector3(2.76f, 5.54f, -16.03f), // Coord2
            new Vector3(-7.24f, 5.54f, -19.28f), // Coord3
            new Vector3(-7.24f, 5.54f, -29.80f), // Coord4
            new Vector3(8.94f, 5.54f, -24.54f), // Coord5
            new Vector3(2.76f, 5.54f, -33.05f), // Coord6
            new Vector3(-8.94f, 14.48f, -24.54f), // Coord7
            new Vector3(-2.76f, 14.48f, -16.03f), // Coord8
            new Vector3(7.24f, 14.48f, -19.28f), // Coord9
            new Vector3(7.24f, 14.48f, -29.80f), // Coord10
            new Vector3(-2.76f, 14.48f, -33.05f), // Coord11
            new Vector3(0.00f, 20.01f, -24.54f)  // Coord12
        };

        // Los triángulos correspondientes
        int[] triangles = {
            0, 2, 3,
            0, 3, 5,
            0, 5, 4,
            0, 4, 1,
            0, 1, 2,

            2, 6, 3,
            3, 6, 10,
            3, 10, 5,
            5, 10, 9,
            5, 9, 4,
            4, 9, 8,
            4, 8, 1,
            1, 8, 7,
            1, 7, 2,
            2, 7, 6,


            7, 11, 6,
            6, 11, 10,
            10, 11, 9,
            9, 11, 8,
            8, 11, 7,
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
