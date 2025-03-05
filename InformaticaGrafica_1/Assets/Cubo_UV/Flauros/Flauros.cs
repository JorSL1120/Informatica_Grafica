using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]

public class Flauros : MonoBehaviour
{
    public Material material;

    void Start()
    {
        CreateFlauros();
    }

    private void CreateFlauros()
    {
        Vector3[] vertices =
        {
            //Figura rara
            new Vector3 (0.5f, 0.82f, 0.29f), //0 +
            new Vector3 (0.5f, 0, 0.87f), //1 +
            new Vector3 (1.5f, 0.82f, 0.29f), //2 +
            new Vector3 (1, 0, 0), //3 +
            new Vector3 (1.5f, 0, 0.87f), //4 +
            new Vector3 (0.5f, 0, 0.87f), //5 +
            new Vector3 (0.5f, 0.82f, 0.29f), //6 +
            new Vector3 (1, 0.82f, 1.16f), //7 +
            new Vector3 (1.5f, 0.82f, 0.29f), //8 +
            new Vector3 (0.5f, 0.82f, 0.29f), //9 +

            //Tetraedro B (cara de la derecha gris)
            new Vector3 (0, 0, 0), //10 +
            new Vector3 (0, 0, 0), //11 +
            new Vector3 (0, 0, 0), //12 +

            //Tetraedro A (cara de la izquierda gris)
            new Vector3 (2, 0, 0), //13 +
            new Vector3 (2, 0, 0), //14 +
            new Vector3 (2, 0, 0), //15 +

            //Tetraedro D (cara de abajo gris)
            new Vector3 (1, 1.64f, 0.58f), //19 +
            new Vector3 (1, 1.64f, 0.58f), //20 +
            new Vector3 (1, 1.64f, 0.58f), //21 +

            //Tetraedro C (cara de frente gris)
            new Vector3 (1, 0, 1.74f), //16 +
            new Vector3 (1, 0, 1.74f), //17 +
            new Vector3 (1, 0, 1.74f), //18 +



            /*
            new Vector3 (0, 0, 0), //0
            new Vector3 (1, 0, 0), //1
            new Vector3 (0.5f, 0.82f, 0.29f), //2
            new Vector3 (0.5f, 0, 0.87f), //3

            new Vector3 (2, 0, 0), //4
            new Vector3 (1.5f, 0.82f, 0.29f), //5
            new Vector3 (1.5f, 0, 0.87f), //6

            new Vector3 (1, 1.64f, 0.58f), //7
            new Vector3 (1, 0.82f, 1.16f), //8

            new Vector3 (1, 0, 1.74f) //9
            */
        };

        int[] triangles =
        {
            //Triangulo B
            10, 0, 3, //face front
            //3, 0, 1, //right face
            1, 0, 10, //left face
            1, 10, 3, //down face

            //Triangulo A
            3, 2, 14, //face front
            14, 2, 4, //right face
            //4, 2, 3, //left face
            4, 3, 14, //down face

            //Triangulo D
            6, 20, 8, //face front
            8, 20, 7, //right face
            7, 20, 6, //left face
            //7, 6, 8, //down face

            //Triangulo C
            //5, 7, 4, //face front
            16, 7, 4, //right face
            5, 7, 16, //left face
            16, 4, 5, //down face



            //Figura rara
            3, 0, 2, //front face
            7, 4, 6, //right face
            7, 8, 9, //left face
            3, 4, 5 //down face
        };

        Vector2[] uvs = {
            new Vector2(0.72f, 0.2f), //0 +
            new Vector2(1, 0.2f), //1 +
            new Vector2(0.58f, 0.4f), //2 +
            new Vector2(0.87f, 0.4f), //3 +
            new Vector2(0.72f, 0.6f), //4 +
            new Vector2(1, 0.6f), //5 +
            new Vector2(0.72f, 1), //6 +
            new Vector2(0.87f, 0.8f), //7 +
            new Vector2(0.58f, 0.8f), //8 +
            new Vector2(1, 1), //9 +

            new Vector2(0.29f, 0), //10 +
            new Vector2(0.58f, 0.4f), //11 +
            new Vector2(0.87f, 0), //12 +

            new Vector2(0.43f, 0.6f), //13 +
            new Vector2(0.14f, 1), //14 +
            new Vector2(0.72f, 1), //15 +

            new Vector2(0.29f, 0), //16 +
            new Vector2(0f, 0.4f), //17 +
            new Vector2(0.58f, 0.4f), //18 +

            new Vector2(0, 0.4f), //19
            new Vector2(0.29f, 0.8f), //20
            new Vector2(0.58f, 0.4f), //21
        };


        Mesh mesh = GetComponent<MeshFilter>().mesh;
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.uv = uvs;
        meshRenderer.material = material;
        mesh.Optimize();
        mesh.RecalculateNormals();
    }
}
