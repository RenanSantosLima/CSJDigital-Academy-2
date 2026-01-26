using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    
    //Tem desse jeito e um outro jeito é declarando uma variavel 
    public void NewGame(string sceneName)
    {
        PlayerPrefs.SetString("scene", "Scenes/" + sceneName);
        SceneManager.LoadScene("Scenes/LoadSystem");
    }
}
