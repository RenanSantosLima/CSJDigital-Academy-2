using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int score;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player"))
        {
            //atualiza a pontuação
            GameController.instance.AddScore(score);
            Destroy(gameObject);
        }
    }
}
