using UnityEngine;

public class Player : MonoBehaviour
{
    private int exp;

    public int Expirence
    {
        //Rtorna
        get{
            return exp;
        }

        //Atribui
        set{
            exp = value;
        }
    }


    public int Life
    {
        get{
            return exp / 10;
        }

        set{
            exp = value * 10;
        }
    }

    public int Healh {set; get;}

    
}
