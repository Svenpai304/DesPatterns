using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private InputHandler inputHandler;

    private void Awake()
    {
        inputHandler = new InputHandler();
    }

    private void Update()
    {
        inputHandler.HandleInput();
    }
}
