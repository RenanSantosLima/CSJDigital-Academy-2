using UnityEngine;

public class Player : MonoBehaviour
{
    public int level = 3;
    public int health = 100;
    public Vector3 playerPos;


    //------------ Salvamento Binario --------------------------
    /*
    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        level = data.level;
        health = data.health;

        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];

        playerPos = position;

        transform.position = position;
    }*/


    //----------- Salvamento PlayerPrefs ----------------------------

    public void Save()
    {
        PlayerPrefsSystem.SavePlayer(this);
    }

    public void Load()
    {
        PlayerPrefsSystem.LoadPlayer(this);

        transform.position = playerPos;
    }
}
