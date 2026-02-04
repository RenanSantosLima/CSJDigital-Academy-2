using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;

public class Health : MonoBehaviourPun
{
    private Rigidbody2D rb;
    private SpriteRenderer spr;
    private BoxCollider2D boxCollider;
    private Player player;

    [SerializeField] private Image fillHealth;
    [SerializeField] private float health;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spr = GetComponent<SpriteRenderer>();
        boxCollider = GetComponent<BoxCollider2D>();
        player = GetComponent<Player>();
    }

    #region RPCs Functions
    [PunRPC]
    public void HealthUpdate(float damage)
    {
        fillHealth.fillAmount -= damage;
        health = fillHealth.fillAmount;
        CheckHealth();
    }

    [PunRPC]
    private void Die()
    {
        rb.gravityScale = 0f;
        boxCollider.enabled = false;
        spr.enabled = false;
        player.canvas.gameObject.SetActive(false);
    }

    [PunRPC]
    private void Revive()
    {
        rb.gravityScale = 1;
        boxCollider.enabled = true;
        spr.enabled = true;
        player.canvas.gameObject.SetActive(true);
        fillHealth.fillAmount = 1;
        health = 1;
    }

    #endregion

    //verifica a vida do personagem
    private void CheckHealth()
    {
        if(photonView.IsMine && health <= 0.1f)
        {
            //personagem morreu
            GameManager.instance.EnableRespawn();
            photonView.RPC("Die", RpcTarget.AllBuffered);
        }
    }


}
