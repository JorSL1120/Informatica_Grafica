using UnityEngine;

public class Dado20UV : MonoBehaviour
{
    public Material material;

    void Start()
    {
        CreateDado();
    }

    private void CreateDado()
    {
        Vector3[] vertices = {
            new Vector3(0, 0, 0), //0
            new Vector3(-0.5f, 0.87f, 0), //1
            new Vector3(0, 1.74f, 0), //2
            new Vector3(0.5f, 2.61f, 0), //3
            new Vector3(-0.5f, 2.61f, 0), //4
            new Vector3(-1, 3.48f, 0), //5
            new Vector3(0, 3.48f, 0), //6
            new Vector3(-0.5f, 4.35f, 0), //7
            new Vector3(0.5f, 4.35f, 0), //8
            new Vector3(1, 3.48f, 0), //9
            new Vector3(1.5f, 4.35f, 0), //10
            new Vector3(2, 5.22f, 0), //11
            new Vector3(2.5f, 4.35f, 0), //12
            new Vector3(2, 3.48f, 0), //13
            new Vector3(3, 3.48f, 0), //14
            new Vector3(2.5f, 2.61f, 0), //15
            new Vector3(1.5f, 2.61f, 0), //16
            new Vector3(2, 1.74f, 0), //17
            new Vector3(2.5f, 0.87f, 0), //18
            new Vector3(1.5f, 0.87f, 0), //19
            new Vector3(1, 1.74f, 0), //20
            new Vector3(0.5f, 0.87f, 0) //21
        };

        int[] triangles = {
            0, 1, 21,
            1, 2, 21,
            21, 2, 20,
            2, 3, 20,
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

        Vector2[] uvs = {
            new Vector2(0, 0.66f),
            new Vector2(0.25f, 0.66f),
            new Vector2(0, 0.33f),
            new Vector2(0.25f, 0.33f),

            new Vector2(0.5f, 0.66f),
            new Vector2(0.5f, 0.33f),
            new Vector2(0.75f, 0.66f),
            new Vector2(0.75f, 0.33f),

            new Vector2(1, 0.66f),
            new Vector2(1, 0.33f),

            new Vector2(0.25f, 1),
            new Vector2(0.5f, 1),

            new Vector2(0.25f, 0),
            new Vector2(0.5f, 0),
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
