using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float nextBall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Spawn random ball at random x position at top of play area
    void Update ()
    {
        if (Time.time > nextBall)
        {
            nextBall += Random.Range(3, 5);
            int ballIndex = Random.Range(0, ballPrefabs.Length);
            // instantiate ball at random spawn location
            Instantiate(ballPrefabs[ballIndex], new Vector3(Random.Range(-22, 7), 30, 0), ballPrefabs[ballIndex].transform.rotation);
        }
    }
}
