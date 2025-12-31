using UnityEngine;

public class EnumScript : MonoBehaviour
{
    public enum Direcoes
    {
        Norte,
        Sul,
        Leste,
        Oeste
    }

    [SerializeField] private Direcoes minhaDirecao;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        switch(minhaDirecao)
        {
            case Direcoes.Norte:
                Debug.Log("Norte selecionado!");
                break;
            case Direcoes.Sul:
                Debug.Log("Sul selecionado!");
                break;
            case Direcoes.Leste:
                Debug.Log("Leste selecionado!");
                break;
            case Direcoes.Oeste:
                Debug.Log("Oeste Selecionado!");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
