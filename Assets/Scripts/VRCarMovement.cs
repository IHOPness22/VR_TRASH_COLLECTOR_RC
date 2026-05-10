using UnityEngine;
using UnityEngine.InputSystem;

public class VRCarMovement : MonoBehaviour
{

    // Update is called once per fram
        public float maxSpeed = 3f;
    public float acceleration = 5f;
    public float turnSpeed = 90f;

    private float currentSpeed = 0f;

    void Update()
    {
        Vector2 stick = Vector2.zero;

        if (Gamepad.current != null)
        {
            stick = Gamepad.current.leftStick.ReadValue();
        }

        float throttle = stick.y; // forward/back
        float steering = stick.x; // left/right

        // Smooth speed
        float targetSpeed = throttle * maxSpeed;
        currentSpeed = Mathf.MoveTowards(
            currentSpeed,
            targetSpeed,
            acceleration * Time.deltaTime
        );

        // Only turn when moving, like an RC car
        if (Mathf.Abs(currentSpeed) > 0.1f)
        {
            float turnAmount = steering *
                   turnSpeed *
                   (Mathf.Abs(currentSpeed) / maxSpeed) *
                   Time.deltaTime;

            transform.Rotate(0f, turnAmount, 0f);
        }

        // Move forward/backward
        transform.position += transform.forward * currentSpeed * Time.deltaTime;
    }


    
}
