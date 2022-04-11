using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshEditor : MonoBehaviour
{
	[SerializeField] private MeshFromCode m_meshFromCode;
	[SerializeField] private MeshFilter m_meshFilter;
	[SerializeField] private MeshRenderer m_meshRenderer;

	[Header("Mesh properties")]
	[SerializeField] private Vector3[] m_vertices;
	[SerializeField] private int[] m_triangles;
	[SerializeField] private Vector3[] m_normals;

	[SerializeField] private bool m_recalculateNormals;
	[SerializeField] private bool m_recalculateBounds;

	private Mesh m_defaultMesh;
	private Mesh m_currentMesh;

	private void Start()
	{
		m_defaultMesh = m_meshFromCode.GeneratedMesh;

		m_currentMesh = new Mesh();
		m_currentMesh.vertices = m_defaultMesh.vertices;
		m_currentMesh.triangles = m_defaultMesh.triangles;
		m_currentMesh.normals = m_defaultMesh.normals;

		m_vertices = m_currentMesh.vertices;
		m_triangles = m_currentMesh.triangles;
		m_normals = m_currentMesh.normals;

		m_meshFilter.mesh = m_currentMesh;
	}

	private void Update()
	{
		m_currentMesh.vertices = m_vertices;
		m_currentMesh.triangles = m_triangles;

		if(m_recalculateNormals)
		m_currentMesh.RecalculateNormals();
		if(m_recalculateBounds)
		m_currentMesh.RecalculateBounds();
	}
}
