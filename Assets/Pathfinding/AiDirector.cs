using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class AiDirector : MonoBehaviour
{
    public Dijkstra pathFinder;
    public GridGenerator grid;
    
    
    void Start()
    {
        grid.GenerateGrid();

        pathFinder.GetAllNodes();

        Node[] nodes = FindObjectsByType<Node>(FindObjectsSortMode.InstanceID);
        List<Node> path =
            pathFinder.FindShortestPath(nodes[Random.Range(0, nodes.Length)], nodes[Random.Range(0, nodes.Length)]);
        pathFinder.DebugPath(path);
    }

    
    void Update()
    {
        
    }
}
