using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshColliderAssignment : MonoBehaviour
{
    //automatically sets up collider based on model's mesh
    void Start()
    {
        gameObject.GetComponent<MeshCollider>().sharedMesh = gameObject.GetComponentInChildren<MeshFilter>().mesh;
    }
}
