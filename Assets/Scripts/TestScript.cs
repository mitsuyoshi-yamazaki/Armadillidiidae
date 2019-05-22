using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// public class TestScript : MonoBehaviour
// {
//     void Start()
//     {
//         StartCoroutine(Generate());
//     }

//     void Update()
//     {
//     }
// }

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class TestScript : MonoBehaviour
{
    private void CreateTerrain()
    {
        GameObject go = this.gameObject;
        MeshFilter mf = go.AddComponent<MeshFilter>();
        MeshRenderer mr = go.AddComponent<MeshRenderer>();

        Mesh mesh = new Mesh();
        List<Vector3> vertices = new List<Vector3>();
        List<int> triangles = new List<int>();

        Vector3[] face = new Vector3[] {
             new Vector3(0, 0, 0),
             new Vector3(1, 0, 0),
             new Vector3(1, 1, 0),
             new Vector3(0, 1, 0)
         };

        int vertexIndex = 0;

        for (uint x = 0; x < 500; x++)
        {
            for (uint y = 0; y < 500; y++)
            {
                Vector3[] currentFace = new Vector3[] {
                      new Vector3(0 + x, 0 + y, 0),
                      new Vector3(1 + x, 0 + y, 0),
                      new Vector3(1 + x, 1 + y, 0),
                      new Vector3(0 + x, 1 + y, 0)
                  };

                vertices.Add(currentFace[0]);
                vertices.Add(currentFace[1]);
                vertices.Add(currentFace[2]);
                vertices.Add(currentFace[3]);

                triangles.Add(0 + vertexIndex);
                triangles.Add(1 + vertexIndex);
                triangles.Add(2 + vertexIndex);
                triangles.Add(0 + vertexIndex);
                triangles.Add(2 + vertexIndex);
                triangles.Add(3 + vertexIndex);

                vertexIndex += 4;
            }
        }

        mesh.vertices = vertices.ToArray();
        mesh.triangles = triangles.ToArray();

        mf.mesh = mesh;
        mesh.RecalculateBounds();
        mesh.RecalculateNormals();
    }
}