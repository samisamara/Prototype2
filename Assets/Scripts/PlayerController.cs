using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    [SerializeField] private float _moveSpeed = 10f;

    private float horizontal;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.linearVelocity = new Vector3(horizontal * _moveSpeed, 0, 0);
    }

    public void Move(InputAction.CallbackContext input)
    {
        horizontal = input.ReadValue<Vector2>().x;
    }
}
