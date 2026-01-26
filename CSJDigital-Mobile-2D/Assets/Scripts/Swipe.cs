using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour
{
    private Vector2 fingerDown;
    private Vector2 fingerUp;
    public bool DetectFinalSwipe = false;

    public float Swipe_Sensitivity = 20f;

    void Update()
    {

        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                fingerUp = touch.position;
                fingerDown = touch.position;
            }

            //Detecta Swipe enquanto o dedo move
            if (touch.phase == TouchPhase.Moved)
            {
                if (!DetectFinalSwipe)
                {
                    fingerDown = touch.position;
                    checkSwipe();
                }
            }

            //Detecta Swipe somente quando tira o dedo
            if (touch.phase == TouchPhase.Ended)
            {
                fingerDown = touch.position;
                checkSwipe();
            }
        }
    }

    void checkSwipe()
    {
        //Checa se o Swipe é vertical
        if (verticalMove() > Swipe_Sensitivity && verticalMove() > horizontalValMove())
        {
            //Debug.Log("Vertical");
            if (fingerDown.y - fingerUp.y > 0)//cima
            {
                OnSwipeUp();
            }
            else if (fingerDown.y - fingerUp.y < 0)//baixo
            {
                OnSwipeDown();
            }
            fingerUp = fingerDown;
        }

        //Checa se o movimento é horizontal
        else if (horizontalValMove() > Swipe_Sensitivity && horizontalValMove() > verticalMove())
        {
            //Debug.Log("Horizontal");
            if (fingerDown.x - fingerUp.x > 0)//direita
            {
                OnSwipeRight();
            }
            else if (fingerDown.x - fingerUp.x < 0)//esquerda
            {
                OnSwipeLeft();
            }
            fingerUp = fingerDown;
        }

        //Sem movimento
        else
        {
            //Debug.Log("Sem swipe!");
        }
    }

    //retorna valor absoluto entre os eixos verticais
    float verticalMove()
    {
        return Mathf.Abs(fingerDown.y - fingerUp.y);
    }

    //retorna valor absoluto entre os eixos horizontais
    float horizontalValMove()
    {
        return Mathf.Abs(fingerDown.x - fingerUp.x);
    }

    //RETORNOS
    void OnSwipeUp()
    {
        Debug.Log("Cima!");   
    }

    void OnSwipeDown()
    {
        Debug.Log("Baixo!");
    }

    void OnSwipeLeft()
    {
        Debug.Log("Esquerda!");
    }

    void OnSwipeRight()
    {
        Debug.Log("Direita!");
    }
}
