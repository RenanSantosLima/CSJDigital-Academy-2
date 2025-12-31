using UnityEngine;

public class Game : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player player_1 = new Player();

        player_1.Expirence = 10;
        Debug.Log(player_1.Expirence);
    }

    
}
