using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MeshData", menuName = "Mesh data", order = 0)]
public class MeshData : ScriptableObject
{
	public Vector3[] Vertices;
	public int[] Triangles;
}
