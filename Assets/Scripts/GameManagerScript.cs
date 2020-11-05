using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    //makes a static instance of the GameManagerScript in-game
    public static GameManagerScript instance;

    //stores the player transform to be referenced by other scripts
    public Transform player;

    //stores the edge values to be referenced by other scripts
    [SerializeField]
    private Transform PosXEdge;
    public float xMax;
    [SerializeField]
    private Transform NegXEdge;
    public float xMin;
    [SerializeField]
    private Transform PosZEdge;
    public float zMax;
    [SerializeField]
    private Transform NegZEdge;
    public float zMin;

    private void Awake()
    {
        instance = this;
        xMax = PosXEdge.position.x;
        xMin = NegXEdge.position.x;
        zMax = PosZEdge.position.z;
        zMin = NegXEdge.position.z;
    }
}
