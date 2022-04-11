using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshEditor : MonoBehaviour
{
	[SerializeField] private Mesh m_defaultMesh;
	[SerializeField] private MeshFilter m_meshFilter;
	[SerializeField] private MeshRenderer m_meshRenderer;

	private void Start()
	{
		Mesh newMesh = new Mesh();
		newMesh.vertices = m_defaultMesh.vertices;
		newMesh.triangles = m_defaultMesh.triangles;
		newMesh.normals = m_defaultMesh.normals;

		m_meshFilter.mesh = newMesh;
	}

}
