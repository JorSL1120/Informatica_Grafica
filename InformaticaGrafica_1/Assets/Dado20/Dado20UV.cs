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
        Vector3[] vertices = 
        {
            new Vector3 (0.27639f, 0.44721f, -0.85064f), //0
            new Vector3 (0, 1, 0), //1
            new Vector3 (0.89442f, 0.44721f, 0), //2
            new Vector3 (0, 1, 0), //3
            new Vector3 (0.276385f, 0.447215f, 0.85064f), //4
            new Vector3 (0, 1, 0), //5
            new Vector3 (-0.7236f, 0.447215f, 0.52572f), //6
            new Vector3 (0, 1, 0), //7
            new Vector3 (-0.7236f, 0.447215f, -0.52572f), //8
            new Vector3 (0, 1, 0), //9
            new Vector3 (0.27639f, 0.44721f, -0.85064f), //10
            new Vector3 (0.7236f, -0.447215f, -0.52572f), //11
            new Vector3 (0, -1, 0), //12
            new Vector3 (-0.276385f, -0.447215f, -0.85064f), //13
            new Vector3 (0, -1, 0), //14
            new Vector3 (-0.894425f, -0.447215f, 0), //15
            new Vector3 (0, -1, 0), //16
            new Vector3 (-0.276385f, -0.447215f, 0.85064f), //17
            new Vector3 (0, -1, 0), //18
            new Vector3 (0.7236f, -0.447215f, 0.52572f), //19
            new Vector3 (0, -1, 0), //20
            new Vector3 (0.7236f, -0.447215f, -0.52572f) //21
        };

        int[] triangles = 
        {
            0, 1, 2, //0
            0, 0, 0, //1
            0, 0, 0, //2
            0, 0, 0, //3
            0, 0, 0, //4
            0, 0, 0, //5
            0, 0, 0, //6
            0, 0, 0, //7
            0, 0, 0, //8
            0, 0, 0, //9
            0, 0, 0, //10
            0, 0, 0, //11
            0, 0, 0, //12
            0, 0, 0, //13
            0, 0, 0, //14
            0, 0, 0, //15
            0, 0, 0, //16
            0, 0, 0, //17
            0, 0, 0, //18
            0, 0, 0, //19
        };

        Vector2[] uvs = 
        {
            
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
