using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;
using TMPro;

public class Lobby : MonoBehaviourPunCallbacks
{
    [SerializeField] private TMP_InputField createRoom;
    [SerializeField] private TMP_InputField joinRoom;
    [SerializeField] private TMP_InputField nickName;
    [SerializeField] private GameObject nickObject;

    private void Start()
    {
        if(PhotonNetwork.NickName != "")
        {
            nickObject.SetActive(false);
        }
    }

    //Metodo chamado ao clicar no botão createRoom
    public void CreateRoomBtn()
    {
        PhotonNetwork.CreateRoom(createRoom.text, new RoomOptions() { MaxPlayers = 4 }, null);
    }

    //Metodo chamado ao clicar no botão joinRoom
    public void JoinRoomBtn()
    {
        PhotonNetwork.JoinRoom(joinRoom.text, null);
    }

    //Metodo chamado ao entrar na sala com sucesso
    public override void OnJoinedRoom()
    {
        Debug.Log("Room Join Success!");
        PhotonNetwork.LoadLevel(1);
    }

    //Chamado se houver erro ao entra na sala
    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        Debug.Log("Room Failed! " + returnCode + " Message: " + message);
    }

    //O nickname do client
    public void GetNickname()
    {
        PhotonNetwork.NickName = nickName.text;
        nickObject.SetActive(false);
    }
}
