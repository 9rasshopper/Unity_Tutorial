using UnityEngine;

public class StudyPolygon : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Mesh mesh = new Mesh();

        Vector3[] new_vertices = new Vector3[]
            {
                new Vector3(0, 0, 0), // Vertex 0
                new Vector3(1, 0, 0), // Vertex 1
                new Vector3(0,1,0),   // Vertex 2
                new Vector3(1, 1, 0) // Vertex 3

            };

        int [] new_triangles = new int[]
            {
                0, 2, 1, // First triangle
                2, 3, 1  // Second triangle
            };

        Vector2[] new_uv = new Vector2[]
            {
                new Vector2(0, 0), // UV for Vertex 0
                new Vector2(1, 0), // UV for Vertex 1
                new Vector2(0, 1), // UV for Vertex 2
                new Vector2(1, 1)  // UV for Vertex 3
            };

        //Mesh에 Vertex, Triangle, UV 데이터를 적용
        mesh.vertices = new_vertices;
        mesh.triangles = new_triangles;
        mesh.uv = new_uv;

        //MeshFilter에 Mesh 데이터를 적용
        MeshFilter meshFilter = this.gameObject.AddComponent<MeshFilter>();
        meshFilter.mesh = mesh;

        //MeshFilter에 Material 데이터를 적용
        MeshRenderer meshRenderer = this.gameObject.AddComponent<MeshRenderer>();
        meshRenderer.material = new Material(Shader.Find("Sprites/Default"));
    }
}
