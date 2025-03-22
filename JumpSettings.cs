using UnityEngine;

[CreateAssetMenu(fileName = "JumpSettings", menuName = "Gameplay/JumpSettings")]
public class JumpSettings : ScriptableObject
{
    public float JumpForce = 10f;
    public int MaxAirJumps = 1; 
    public float GravityScale = 2f; 
    public float CoyoteTime = 0.1f; 
}