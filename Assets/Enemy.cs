using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    private Vector3 playerPosition;
    public NavMeshAgent enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //constantly sets a vector 3 to players current position
        playerPosition = player.transform.position;
        //enemy constantly tries to get to that position (vector 3 being set)
        enemy.SetDestination(playerPosition);
    }
}
