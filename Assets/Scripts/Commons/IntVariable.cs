using UnityEngine;

[CreateAssetMenu(fileName = "IntValue", menuName = "Value/Int")]
public class IntVariable : ScriptableObject
{
    [SerializeField] private int intValue;
    public int Value
    {
        get => intValue;
        set => intValue = value;
    }
}
