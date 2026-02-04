using UnityEngine;
using Photon.Pun;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject player;

    [Header("Respawn Settings:")]
    [SerializeField] private TextMeshProUGUI spawnTimer;    //Campo de texto
    [SerializeField] private GameObject respawnUI;          //UI do respawn
    [SerializeField] private float totalRespawnTime;        //Tempo total do respawn

    [Header("Ping Settings:")]
    [SerializeField] private TextMeshProUGUI pingText;      //Info do ping

    private float respawnTime;                              //Faz a contagem do tempo do respawn
    private bool startRespawn;                              //Se verdadeira, está esperando para reviver

    [HideInInspector]
    public GameObject localPlayer;                          //Player do atual cliente

    public bool isAlive = true;

    public static GameManager instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        SpawnPlayer();

        respawnTime = totalRespawnTime;
    }

    private void Update()
    {
        if(startRespawn)
        {
            StartRespawn();
        }

        pingText.text = "Ping: " + PhotonNetwork.GetPing().ToString();
    }

    public void SpawnPlayer()
    {
        float random = 0f;
        PhotonNetwork.Instantiate(player.name, new Vector2(player.transform.position.x + random, player.transform.position.y), Quaternion.identity);
    }

    public void LeaveRoom()
    {
        PhotonNetwork.LeaveRoom();
        PhotonNetwork.LoadLevel(0);
    }

    #region Respawn Functions

    private void StartRespawn()
    {
        isAlive = false;

        respawnTime -= Time.deltaTime;
        spawnTimer.text = "Respawn in: " + respawnTime.ToString("F0");

        if(respawnTime <= 0)
        {
            respawnUI.SetActive(false);
            localPlayer.GetComponent<PhotonView>().RPC("Revive", RpcTarget.AllBuffered);
            PlayerRespawnPos();
            isAlive = true;
            startRespawn = false;
            
        }
    }

    private void PlayerRespawnPos()
    {
        float randomPos = Random.Range(-4, 4);
        localPlayer.transform.localPosition = new Vector2(randomPos, 2);
    }

    public void EnableRespawn()
    {
        respawnTime = totalRespawnTime;
        startRespawn = true;
        respawnUI.SetActive(true);
    }

    #endregion


}
