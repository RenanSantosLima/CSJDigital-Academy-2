using UnityEngine;
using Photon.Pun;
using System.Collections;

public class Bullet : MonoBehaviourPun
{
    [SerializeField] private float speed;
    [SerializeField] private float destroyTime;

    private bool isLeft;

    private void Start()
    {
        StartCoroutine(FinishBullet());
    }

    private void Update()
    {
        if(isLeft)
        {
            //Vai para esquerda
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        else
        {
            //Vai para direita
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
    }

    [PunRPC]
    private void DestroyBullet()
    {
        Destroy(gameObject);
    }

    [PunRPC]
    public void MoveLeft()
    {
        isLeft = true;
    }


    private IEnumerator FinishBullet()
    {
        yield return new WaitForSeconds(destroyTime);
        photonView.RPC("DestroyBullet", RpcTarget.AllBuffered);
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if(!photonView.IsMine)
        {
            return;
        }

        PhotonView target = col.gameObject.GetComponent<PhotonView>();

        if(target != null)
        {
            if(target.CompareTag("Player"))
            {
                target.RPC("HealthUpdate", RpcTarget.AllBuffered, 0.2f);
            }

            photonView.RPC("DestroyBullet", RpcTarget.AllBuffered);
        }
    }

}
