using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Personaje : MonoBehaviour
{
    public Controles input;
    private PlayerInput playerInput;
    // Start is called before the first frame update
    void Awake()
    {
        input = new Controles();
        input.Personaje.Movimiento.performed += Move;
        input.Personaje.Movimiento.performed += ctx => Salto(ctx.ReadValue<Vector2>());

        //Cambiar las lineas de arriba por estas si se utiliza un PlayerInput
        playerInput.actions["Movimiento"].performed += Move;
        playerInput.actions["Saltar"].performed += ctx => Salto(ctx.ReadValue<Vector2>());
        playerInput = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        Keyboard kb = InputSystem.GetDevice<Keyboard>();
        Mouse mouse = InputSystem.GetDevice<Mouse>();
        Gamepad gamePad = InputSystem.GetDevice<Gamepad>();

        if (kb.pKey.wasPressedThisFrame)
        {
            Debug.Log(kb);
        }

        if (mouse.leftButton.wasPressedThisFrame) 
        {
            print("Fue presionado el boton izquierdo");
        }
        if (gamePad.buttonNorth.wasPressedThisFrame)
        {
            print("fue presionado el boton del norto de un control(en el xbox seria la y)");
        }

        /*traditional input
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical"); */

        /*Vector2 move = input.Personaje.Movimiento.ReadValue<Vector2>();
        Debug.Log(move);

        if (input.Personaje.Movimiento.ReadValue<Vector2>())
        {

        }*/
    }
    private void Move(InputAction.CallbackContext ctx)
    {
        Vector2 dir = (ctx.ReadValue<Vector2>());
    }
    private void Salto(Vector2 dir)
    {
        Debug.Log(dir);
    }

    private void OnEnable()
    {
        input.Enable();
    }
    private void OnDisable()
    {
        input.Disable();
    }
}
