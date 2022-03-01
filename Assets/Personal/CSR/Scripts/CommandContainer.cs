using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandContainer : MonoBehaviour
{
    //These fields are visible in the inspector, which can be useful for testing.
    //But in same cases we might want to use [HideInInspector] or getters/setters to hide these fields.
    
    public float walkCommand;
    public bool JumpCommandDowen;
    public bool JumpCommandUp;
    public bool JumpICommand;
}
