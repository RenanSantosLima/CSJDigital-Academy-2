using UnityEngine;

public class TouchScreen : MonoBehaviour
{
    private void Update()
    {
        //Um toque na tela
        // if(Input.touchCount > 0)
        // {
        //     Touch touch = Input.GetTouch(0);
        //     Vector3 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
        //     touchPos.z = 0f;
        //     transform.position = touchPos;
        // }

        //VArios toques oa mesmo tempo
        // for(int i = 0; i < Input.touchCount; i++)
        // {
        //     Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.touches[i].position);
        //     Debug.DrawLine(Vector3.zero, touchPos, Color.red);
        // }

        //Usando TouchPhase
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Began)
            {
                Debug.Log("Tocou!");
            }

            //não considara touch
            if(touch.phase == TouchPhase.Canceled)
            {
                Debug.Log("Toque incorreto!");
            }

            //tirou o dedo da tela
            if(touch.phase == TouchPhase.Ended)
            {
                Debug.Log("Tirou o dedo!");
            }

            //moveu o dedo na tela
            if(touch.phase == TouchPhase.Moved)
            {
                Debug.Log("Moveu o dedo!");
            }

            //dedo parado sem se mover na tela
            if(touch.phase == TouchPhase.Stationary)
            {
                Debug.Log("Dedo parado na tela!");
            }
        }
    }
}
