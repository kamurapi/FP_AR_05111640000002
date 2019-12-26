using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
	//public DefaultTrackableEventHandler deftrack;
    public GameObject enemy;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;
	//public GameObject EnemyContainer;


    void Start ()
    {
		
		//if (deftrack.gamestart == true)
			InvokeRepeating ("Spawn", spawnTime, spawnTime);
    }
	void Update()
	{
		//Debug.Log(deftrack.gamestart);
		//Invoke ("Spawn", spawnTime, spawnTime);
	}


    void Spawn ()
    {
        if(playerHealth.currentHealth <= 0f)
        {
            return;
        }

        int spawnPointIndex = Random.Range (0, spawnPoints.Length);
		Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
		//GameObject enemyClone = Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
		//enemyClone.transform.parent = EnemyContainer.transform;
		//powerUpClone.name = "PowerUp" + (i);
	}
}
