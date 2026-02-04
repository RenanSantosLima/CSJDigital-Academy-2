using UnityEngine;
using Photon.Pun;
using TMPro;

public class Player : MonoBehaviourPun, IPunObservable
{
    private Rigidbody2D rb;
    private Animator anim;
    [SerializeField] private float speed;

    private Vector2 clientPos;

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firePoint;

    [SerializeField] private TextMeshProUGUI nickNameText;
    public Transform canvas;

    private float moviment;

    private void Awake()
    {
        if(photonView.IsMine)
        {
            GameManager.instance.localPlayer = this.gameObject;
            nickNameText.text = PhotonNetwork.NickName;
        }
        else
        {
            nickNameText.text = photonView.Owner.NickName;
        }
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        if (photonView.IsMine && GameManager.instance.isAlive)
        {
            //Minha movimentação
            ProcessInput();
        }
        else
        {
            //Sincorniza outros players
            SmoothMoviment();
        }
    }

    #region myClient
    private void ProcessInput()
    {
        moviment = Input.GetAxis("Horizontal");

        rb.linearVelocity = new Vector2(moviment * speed, rb.linearVelocity.y);

        if(Input.GetKeyDown(KeyCode.E))
        {
            anim.SetTrigger("shoot");
            this.photonView.RPC("Shoot", RpcTarget.Others);
        }

        if (moviment > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            canvas.eulerAngles = new Vector3(0, 0, 0);
            this.photonView.RPC("ChangeRight", RpcTarget.Others);
        }
        else if (moviment < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
            canvas.eulerAngles = new Vector3(0, 0, 0);
            this.photonView.RPC("ChangeLeft", RpcTarget.Others);
        }
        else
        {

        }
    }

    #endregion

    #region RPCs Functions
    [PunRPC]
    private void ChangeLeft()
    {
        transform.eulerAngles = new Vector3(0, 180, 0);
        canvas.eulerAngles = new Vector3(0, 0, 0);
    }

    [PunRPC]
    private void ChangeRight()
    {
        transform.eulerAngles = new Vector3(0, 0, 0);
        canvas.eulerAngles = new Vector3(0, 0, 0);
    }

    [PunRPC]
    private void Shoot()
    {
        GameObject b = PhotonNetwork.Instantiate(bulletPrefab.name, firePoint.position, firePoint.rotation);
        
        if(moviment < 0)
        {
            b.GetComponent<PhotonView>().RPC("MoveLeft", RpcTarget.AllBuffered);
        }

        anim.SetTrigger("shoot");
    }

    #endregion

    #region othersClient
    private void SmoothMoviment()
    {
        //transform.position = Vector3.Lerp(transform.position, clientPos, Time.fixedDeltaTime);
        rb.position = Vector2.MoveTowards(rb.position, clientPos, Time.fixedDeltaTime);
    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if(stream.IsWriting)
        {
            stream.SendNext(rb.position);
            stream.SendNext(rb.linearVelocity);
        }
        else if(stream.IsReading)
        {
            clientPos = (Vector2)stream.ReceiveNext();
            rb.linearVelocity = (Vector2)stream.ReceiveNext();

            float lag = Mathf.Abs((float)(PhotonNetwork.Time - info.SentServerTime));
            clientPos += rb.linearVelocity * lag;
        }



        // if(stream.IsWriting)
        // {
        //     stream.SendNext(transform.position);
        // }
        // else if(stream.IsReading)
        // {
        //     clientPos = (Vector2)stream.ReceiveNext();
        // }
    }

    #endregion



    

}
