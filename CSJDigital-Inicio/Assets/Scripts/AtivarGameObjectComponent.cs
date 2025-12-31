using UnityEngine;

public class AtivarGameObjectComponent : MonoBehaviour
{
    [SerializeField] private GameObject objeto;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //objeto.SetActive(false);//controla todo ele
        //objeto.GetComponent<Light>().enabled = false;//desativa só um componente

        if(objeto.activeSelf)
        {
            objeto.SetActive(false);
            Debug.Log(objeto.activeSelf);
        }
        else
        {
            objeto.SetActive(true);
            Debug.Log(objeto.activeSelf);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
