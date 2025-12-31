using UnityEngine;

public class If : MonoBehaviour
{
    [SerializeField] private int n1;
    [SerializeField] private int n2;

    [SerializeField] private bool value;


    [SerializeField] private int diaSemana;         //Usado no switch

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //If Condicional
        //CondicionalIf();

        //Switch Condicional
        CondicionalSwitch();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #region Condicional IF, Else IF, Else

    private void CondicionalIf()
    {
        //Debug.Log(value);
        //Debug.Log(n1 + "" + n2);

        if(n1 > 0) {
            Debug.Log("Número positivo");
        }
        else if(n1 < 0) {
            Debug.Log("Numero negativo");
        }
        else {
            Debug.Log("Número igual a zero");
        }
    }

    #endregion







    #region Condicional Switch

    private void CondicionalSwitch()
    {
        switch(diaSemana)
        {
            case 1:
                Debug.Log("Domingo!");
                break;

            case 2:
                Debug.Log("Segunda!");
                break;

            case 3:
                Debug.Log("Terça");
                break;

            case 4:
                Debug.Log("Quarta!");
                break;
            
            default:
                Debug.Log("Fora de data!");
                break;
        }
    }

    #endregion




}
