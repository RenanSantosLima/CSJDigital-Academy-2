using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public Vector2 lastCheckPoint;


    [SerializeField] private int highScore;
    [SerializeField] private int score;
    [SerializeField] private TextMeshProUGUI scoreText;

    private void Start()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }

        highScore = PlayerPrefs.GetInt("HighScore");
    }

    //------ HighScore ------
    public int AddScore(int amount)
    {
        score += amount;
        scoreText.text = score.ToString();
        Record();
        return score;
    }


    private void Record()
    {
        if(PlayerPrefs.GetInt("HighScore") < score)
        {
            //Salva o novo score
            PlayerPrefs.SetInt("HighScore", score);
            highScore = score;
        }
        else
        {
            //Record não batido
        }
    }
}
