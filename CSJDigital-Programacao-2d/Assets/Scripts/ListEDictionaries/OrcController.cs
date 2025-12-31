using System.Collections.Generic;
using UnityEngine;

public class OrcController : MonoBehaviour
{
    private List<Orc> orcList = new List<Orc>();                            //Lista
    private Dictionary<string, Orc> orc = new Dictionary<string, Orc>();    //Dicionario


    private void Start()
    {
        UsingList();
        UsingDictionary();
    }

    private void UsingList()
    {
        orcList.Add(new Orc("Durotan", 10));
        orcList.Add(new Orc("Arlan", 20));
        orcList.Add(new Orc("Duke", 30));

        foreach(Orc c in orcList)
        {
            Debug.Log(c.name);
        }
    }


    private void UsingDictionary()
    {
        Orc orc1 = new Orc("Durotan", 50);
        Orc orc2 = new Orc("Arlan", 60);
        Orc orc3 = new Orc("Duke", 70);
        Orc orc4 = new Orc("Tristan", 100);

        orc.Add("gerreiro", orc1);
        orc.Add("mago", orc2);
        orc.Add("cozinehiro", orc3);

        Orc orc5 = orc["mago"];
        Orc orc6 = null;

        if(orc.TryGetValue("mago", out orc5))
        {
            Debug.Log("Existe!");
        }
        else
        {
            Debug.Log("Não existe!");
        }
    }

    
}
