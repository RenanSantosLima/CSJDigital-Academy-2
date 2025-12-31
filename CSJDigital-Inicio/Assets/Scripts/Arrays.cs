using UnityEngine;

public class Arrays : MonoBehaviour
{
    [SerializeField] private GameObject[] player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player");

        for(int i = 0; i < player.Length; i++)
        {
            Debug.Log(player[i].name);
        }

        /*foreach(GameObject p in player)
        {
            Debug.Log(p.name);
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
