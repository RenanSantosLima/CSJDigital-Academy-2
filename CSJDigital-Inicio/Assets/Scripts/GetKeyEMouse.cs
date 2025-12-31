using UnityEngine;
using UnityEngine.InputSystem;

public class GetKeyEMouse : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Tempo todo da tecla
        if(Input.GetKey(KeyCode.A))
        {
            Debug.Log("A tecla A foi pressionada!");
        }

        //Quando presionado a tecla
        if(Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("A telca B foi pressionada!");
        }

        //Quando é solta a tecla
        if(Input.GetKeyUp(KeyCode.C))
        {
            Debug.Log("A tecla C foi presionada");
        }
    }

    #region Mouse 

    //O Script tem que estar dentro do objeto em questão, se não funciona

    /*
    private void OnMouseDown()
    {
        Debug.Log("Clicou");
    }*/

    private void OnMouseDrag()
    {
        Debug.Log("Clicou e manteve presssionado!");
    }

    /*
    private void OnMouseEnter()
    {
        Debug.Log("Passou o mouse em cima!");
    }

    private void OnMouseExit()
    {
        Debug.Log("Tirou o mouse de cima!");
    }

    private void OnMouseOver()
    {
        Debug.Log("Ficou em cima do objeto!");
    }

    private void OnMouseUp()
    {
        Debug.Log("Parou de pressionar o botão do mouse!");
    }

    private void OnMouseUpAsButton()
    {
        Debug.Log("Para de pressionar e fica no mesmo objeto!");
    }*/

    #endregion
}
