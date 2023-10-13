using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler
{
    public static InputHandler Instance { get; private set; }

    public Dictionary<KeyCode, ICommand> KeyCommands = new Dictionary<KeyCode, ICommand>();

    public InputHandler()
    {
        Instance = this;
    }

    public void AddCommand(KeyCode keyCode, ICommand command)
    {
        if (!KeyCommands.ContainsKey(keyCode))
        {
            KeyCommands.Add(keyCode, command);
        }
    }

    public void RemoveCommand(KeyCode keyCode)
    {
        if (KeyCommands.ContainsKey(keyCode))
        {
            KeyCommands.Remove(keyCode);
        }
    }

    public void HandleInput()
    {
        List<ICommand> usedCommands = new List<ICommand>();
        foreach (var command in KeyCommands)
        {
            if (Input.GetKeyDown(command.Key) && !usedCommands.Contains(command.Value))
            {
                command.Value.Execute();
                usedCommands.Add(command.Value);
            }
        }
    }
}
