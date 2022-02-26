using UnityEngine;

/// <summary>
/// Stores each possible state.
/// </summary>
public class StateMachine
{
    public static OnGround onGround = new OnGround();
    public static InAir inAir = new InAir();
    public static Jumping jumping = new Jumping();
    public static Sliding sliding = new Sliding();
    public static Standing standing = new Standing();
    public static Climbing climbing = new Climbing();
    public static Running running = new Running();
    public static Jetpacking jetpacking = new Jetpacking();
}

/// <summary>
/// An interface for what happens when a player performs certain actions.
/// </summary>
public interface PlayerState
{
    void OnEnter(GameObject player);
    void OnExit(GameObject player);
    PlayerState HandleInput(GameObject player);
    void Update(GameObject player);
}
