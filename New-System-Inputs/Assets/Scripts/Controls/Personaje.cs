using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Personaje : MonoBehaviour
{
    public Controles input;
    // Start is called before the first frame update
    void Awake()
    {
        input = new Controles();
        input.Personaje.Movimiento.performed += Move;
        input.Personaje.Movimiento.performed += ctx => Salto(ctx.ReadValue<Vector2>());
    }

    // Update is called once per frame
    void Update()
    {
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
