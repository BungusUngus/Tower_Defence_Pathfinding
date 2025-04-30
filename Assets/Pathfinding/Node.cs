using System;
using System.Collections.Generic;
using UnityEngine;
using Vector3 = System.Numerics.Vector3;

public class Node : MonoBehaviour
{
    public List<Node> Neighbours;

    private float pathWeight = float.PositiveInfinity;

    public float PathWeight
    {
        get => pathWeight;
        set => pathWeight = value;
    }
    
    public Node PreviousNode { get; set; }

    public void ResetNode()
    {
        pathWeight = float.PositiveInfinity;
        PreviousNode = null;
    }

    private void OnDrawGizmos()
    {
        if(Neighbours == null) return;
        float radius = 0.2f;

        Gizmos.color = Color.blue;
        foreach (var node in Neighbours)
        {
            if(node == null) continue;
            Vector3 direction = node.transform.position - transform.position;
            Vector3 right = Vector3.Cross(direction, Vector3.up).normalized * 0.03f;
            
            Gizmos.DrawLine(transform.position + right, direction);
        }

        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, radius);
    }
}
