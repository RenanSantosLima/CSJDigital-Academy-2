using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float spawnTimer;
    [SerializeField] private List<GameObject> paredes = new List<GameObject>();
    private float timerOfWall;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timerOfWall += Time.deltaTime;

        if(timerOfWall >= spawnTimer)
        {
            Instantiate(paredes[Random.Range(0, paredes.Count)], transform.position, transform.rotation);
            timerOfWall = 0f;
        }
    }
}
