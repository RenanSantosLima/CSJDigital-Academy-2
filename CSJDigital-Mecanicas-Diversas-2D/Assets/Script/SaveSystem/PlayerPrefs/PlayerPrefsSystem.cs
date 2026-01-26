using UnityEngine;

public class PlayerPrefsSystem : MonoBehaviour
{
    
    public static void SavePlayer(Player player)
    {
        PlayerPrefs.SetInt("level", player.level);
        PlayerPrefs.SetInt("health", player.health);
        PlayerPrefs.SetFloat("positionX", player.playerPos.x);
        PlayerPrefs.SetFloat("positionY", player.playerPos.y);
        PlayerPrefs.SetFloat("positionZ", player.playerPos.z);

        Debug.Log("Jogo salvo com sucesso!");

    }

    public static Player LoadPlayer(Player player)
    {
        if(PlayerPrefs.HasKey("level"))
        {
            //Já existe algo salvo, carregar jogo
            player.level = PlayerPrefs.GetInt("level");
            player.health = PlayerPrefs.GetInt("health");
            player.playerPos.x = PlayerPrefs.GetFloat("positionX");
            player.playerPos.y = PlayerPrefs.GetFloat("positionY");
            player.playerPos.z = PlayerPrefs.GetFloat("positionZ");

            Debug.Log("jogo carregado com sucesso!");

            return player;
        }
        else
        {
            //Não esiste nada 
            Debug.Log("Não foi!");
            return null;
        }
    }




}
