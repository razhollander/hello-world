public class PlayerController : MonoBehaviour
{
    [SerializedField] private JumpSettings _jumpSettings;
    
    private Rigidbody2D _rigidbody;
    private int _remainingJumps;
    
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _remainingJumps = _jumpSettings.maxAirJumps;
    }
    
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            AttemptJump();
        }
    }
    
    void AttemptJump()
    {
        if (IsGrounded())
        {
            PerformJump();
            _remainingJumps = _jumpSettings.maxAirJumps;
        }
        else if (_remainingJumps > 0)
        {
            PerformJump();
            _remainingJumps--;
        }
    }
    
    void PerformJump()
    {
        _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, 0);
        _rigidbody.AddForce(Vector2.up * _jumpSettings.jumpForce, ForceMode2D.Impulse);
    }
    
    bool IsGrounded()
    {
        return Physics2D.Raycast(transform.position, Vector2.down, 0.1f);
    }
}