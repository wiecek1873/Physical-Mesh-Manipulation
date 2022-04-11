using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshFromCode : MonoBehaviour
{
	[HideInInspector] public Mesh GeneratedMesh;

	[SerializeField] private Vector3[] m_vertices;
	[SerializeField] private int[] m_triangles;

	private void Awake()
	{
		GeneratedMesh = new Mesh();
		GeneratedMesh.vertices = m_vertices;
		GeneratedMesh.triangles = m_triangles;

		//Vector2[] uvs = new Vector2[m_vertices.Length];

		//for (int i = 0; i < uvs.Length; i++)
		//{
		//	uvs[i] = new Vector2(m_vertices[i].x, m_vertices[i].z);
		//}

		//GeneratedMesh.uv = uvs;
		GeneratedMesh.RecalculateNormals();
	}
}
