using UnityEngine;

public class PlayerWalkController : MonoBehaviour
{
    [Header("Dependencies")]
    [SerializeField] private Rigidbody myRigidbody;
    [SerializeField] private PlayerInputController playerInputController;
    [SerializeField] private GroundChecker groundChecker;
    
    [Header("Movement")]
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float chargingMoveSpeedFactor = 0.5f;

    [Header("Dash")] 
    [SerializeField] private float dashSpeed;
    [SerializeField] private float dashTime;

    private Walk _walk;
    private Dash_Imidiate _dash;
    
    public bool CanWalk { get; set; }
    public bool CanDash { get; set; }

    private void Awake()
    {
        _walk = new Walk(myRigidbody, moveSpeed);
        _dash = new Dash_Imidiate(myRigidbody, dashSpeed, dashTime);
        
        CanWalk = true;
        CanDash = true;
    } 
    
    private void Update()
    {
        if (playerInputController.DashInput && CanDash && playerInputController.MoveInput != 0)
        {
            CanDash = false;
            CanWalk = false;
            var inputNormalized = Mathf.Sign(playerInputController.MoveInput);
            StartCoroutine(_dash.Execute(inputNormalized));
        }
        else if(CanWalk) _walk.Move(playerInputController.MoveInput);
        
        CanWalk = _dash.CanWalk();
        CanDash = _dash.CanDash();
    }

    private void OnCollisionEnter(Collision other) => CanWalk = true;
}