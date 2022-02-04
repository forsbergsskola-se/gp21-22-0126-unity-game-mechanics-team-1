using TMPro;
using UnityEngine;

public class DisplayLife : MonoBehaviour
{
    [SerializeField] private IntVariable playersLife;
    [SerializeField] private TextMeshProUGUI textMesh;

    private void Start() => UpdateDisplay();
    
    public void UpdateDisplay()
    {
        textMesh.text = "Life: " + playersLife.Value;
    }
}
