using UnityEngine;

[CreateAssetMenu(fileName = "IntValue", menuName = "Value/Int")]
public class IntVariable : ScriptableObject
{
    [SerializeField] private int intValue;
    public int Int
    {
        get => intValue;
        set => intValue = value;
    }
}
