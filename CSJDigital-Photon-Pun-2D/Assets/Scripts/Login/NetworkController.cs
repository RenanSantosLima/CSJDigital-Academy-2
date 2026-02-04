using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class NetworkController : MonoBehaviourPunCallbacks
{
    [SerializeField] private GameObject connectedScreen;
    [SerializeField] private GameObject disconnectedScreen;

    //Conecta no servidor
    public void ConnectBtn()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    //Entra no lobby
    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby(TypedLobby.Default);
    }

    //Conexão falhou
    public override void OnDisconnected(DisconnectCause cause)
    {
        disconnectedScreen.SetActive(true);
        Debug.Log(cause);
    }

    //Apos login no lobby
    public override void OnJoinedLobby()
    {
        connectedScreen.SetActive(true);
    }
}
