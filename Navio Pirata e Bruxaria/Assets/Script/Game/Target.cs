using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private string state = "idle";
    public string State => state;

    public void SetState(string newState)
    {
        state = newState;
    }
}
