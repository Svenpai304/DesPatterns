using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private InputHandler inputHandler = new InputHandler();
    [SerializeField] private KeyCommand[] keyCommands;


    private void Start()
    {
        foreach (var command in keyCommands)
        {
            inputHandler.AddCommand(command.keyCode, command.commandHolder.GetComponent<ICommand>());
            Debug.Log("Added key " +  command.keyCode);
        }
    }

    private void Update()
    {
        inputHandler.HandleInput();
    }
}

[Serializable]
public class KeyCommand
{
    public KeyCode keyCode;
    public GameObject commandHolder;
}
