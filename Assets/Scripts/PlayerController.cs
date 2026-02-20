using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    [SerializeField] private float _moveSpeed = 10f;

    private float horizontal;
    public float xRange = 10;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.x < -xRange) 
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        } 
        else if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
            rb.linearVelocity = new Vector3(horizontal * _moveSpeed, 0, 0);
    }

    public void Move(InputAction.CallbackContext input)
    {
        horizontal = input.ReadValue<Vector2>().x;
    }

    public void Throw(InputAction.CallbackContext input) 
    { 
        
    }

}
