using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    private PlayerInput playerInput;
    private PlayerInput.OnFootActions onFoot;
    private PlayerController playerController;
    private PlayerLook look;


    private void Awake() 
    {
        playerInput = new PlayerInput();
        onFoot = playerInput.OnFoot;    
        playerController = GetComponent<PlayerController>();
        look = GetComponent<PlayerLook>();
        onFoot.Jump.performed += ctx => playerController.Jump(); 
    }

    private void OnEnable() 
    {
        onFoot.Enable();    
    }

    private void OnDisable() 
    {
        onFoot.Disable();    
    }

    private void FixedUpdate()
    {
        playerController.Move(onFoot.Movement.ReadValue<Vector2>());
    }

    private void LateUpdate()
    {
        look.Look(onFoot.Look.ReadValue<Vector2>());
    }
}
