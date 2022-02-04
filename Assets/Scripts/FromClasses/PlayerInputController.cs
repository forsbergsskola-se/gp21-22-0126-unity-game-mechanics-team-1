using Unity.VisualScripting;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    public float MoveInput { get; private set; }
    public bool JumpInputDown { get; private set; }
    public bool JumpInputUp { get; private set; }
    public bool JumpInput { get; private set; }
    public bool DashInput { get; private set; }
    public bool DashCharge { get; private set; }
    public bool ShootInput { get; private set; }

    private void Update()
    {
        MoveInput = Input.GetAxis("Horizontal");
        JumpInputDown = Input.GetKeyDown(KeyCode.Space);
        JumpInputUp = Input.GetKeyUp(KeyCode.Space);
        JumpInput = Input.GetKey(KeyCode.Space);
        DashInput = Input.GetKey(KeyCode.W);
        DashCharge = Input.GetKey(KeyCode.E);
        ShootInput = Input.GetMouseButtonDown(0);

    }
}
