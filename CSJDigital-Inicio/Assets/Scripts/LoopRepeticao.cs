using UnityEngine;

public class LoopRepeticao : MonoBehaviour
{
    private int numberOfEnemies = 3;

    private string[] enemies = new string[3];

    private int itensCena = 5;

    private int dinheiro = 500;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Teste do foreach
        enemies[0] = "Inimigo 1";
        enemies[1] = "Inimigo 2";
        enemies[2] = "Inimigo 3";

        LoopFor();
        LoopForeach();
        LoopWhile();
        LoopDoWhile();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    #region Laço de repetição For

    private void LoopFor()
    {
        for(int i = 0; i < numberOfEnemies; i++)
        {
            Debug.Log("O número de inimigos é: " + i);
        }
    }


    #endregion


    #region Laço de repetição Foreach

    private void LoopForeach()
    {
        foreach(string i in enemies)
        {
            Debug.Log(i);
        }
    }

    #endregion


    #region Laço repetição While

    private void LoopWhile()
    {
        while(itensCena > 0)
        {
            Debug.Log("Item pegado!");
            itensCena--;
        }
    }

    #endregion


    #region Laço repetição Do While

    private void LoopDoWhile()
    {
        do
        {
            Debug.Log("Oseu dinheiro é: " + dinheiro);
            dinheiro += 50;

        } while(dinheiro < 1000);
    }

    #endregion





}
