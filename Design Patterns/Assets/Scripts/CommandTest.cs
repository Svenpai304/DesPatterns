using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandTest : MonoBehaviour, ICommand
{
    public void Execute()
    {
        Debug.Log("Input!");
    }
}
