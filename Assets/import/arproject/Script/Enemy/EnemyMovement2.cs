using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement2 : MonoBehaviour
{
    Transform player;
    NavMeshAgent nav;
    
    // Start is called before the first frame update
    void Start()
    {

		Debug.Log("22");
	}

    void Awake()
    {
		Debug.Log("masuk");
		player = GameObject.FindGameObjectWithTag("Player").transform;
		Debug.Log(player.position);
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
		nav.SetDestination(player.position); 
    }
}
