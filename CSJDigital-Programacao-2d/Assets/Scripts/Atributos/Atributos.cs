using UnityEngine;

public class Atributos : MonoBehaviour
{
    [Header("Variaveis numericas:")]
    [HideInInspector]   //Oculta variaveis publicas do inspetor
    public int score;

    [SerializeField]    //Mostra variaveis privadas no inspetor   
    private int points;

    [Space]     //Espaçamento entre variaveis
    [Header("Outas variavies:")]    //Titulo do cabeçalho
    [Tooltip("Variaveis que não são numericas")]    //instrução ao passar o mouse
    public string teste;

    [Range(-5f,5f)] //barra visual com dois valores
    public float healthBar;

    [TextArea]  //Area de texto grande
    public string textArea;
}
