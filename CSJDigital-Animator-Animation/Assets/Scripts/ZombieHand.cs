using UnityEngine;

public class ZombieHand : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Enemy"))
        {
            Debug.Log("Acertou!!!");
        }
    }
}
