using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class InputControl : MonoBehaviour
{
    private PlayerInput playerInput;
    private PlayerInputSystemMoviment player;

    private void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        player = GetComponent<PlayerInputSystemMoviment>();
    }

    //metodo de movimentação
    public void OnMove(CallbackContext context)
    {
        player.Move(context.ReadValue<Vector2>());
    }

    public void OnAtck(CallbackContext context)
    {
        if(context.started)
        {
            Debug.Log("Atacou!");
        }
    }
}
