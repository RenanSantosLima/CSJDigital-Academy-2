using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private GameController gc;

    private void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GC").GetComponent<GameController>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player"))
        {
            gc.lastCheckPoint = transform.position;
        }
    }
}
