using UnityEngine;

public class Orc : MonoBehaviour
{
    [SerializeField] private string nome;
    [SerializeField] private int level;

    public Orc(string newNome, int newLevel)
    {
        nome= newNome;
        level = newLevel;
    }
}
