using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float moveInput = 0f;
    private float SteerInput;

    public bool autoDrive = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!autoDrive) {
        moveInput = 0f;
        SteerInput = 0f;
        if (Input.GetKey(KeyCode.W))
        {
            moveInput = 1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveInput = -1f;        
        }
        float angle = transform.eulerAngles.y*Mathf.Deg2Rad;
        Vector3 forward = new Vector3(Mathf.Sin(angle),0,Mathf.Cos(angle));
        transform.position += forward*5f*moveInput*Time.deltaTime;

        if (Input.GetKey(KeyCode.D))
            {
                SteerInput = 2f;
            }
        if (Input.GetKey(KeyCode.A))
            {
                SteerInput = -2f;
            }    
        transform.Rotate(0, SteerInput*45*Time.deltaTime,0);
        }

        if (autoDrive)
        {
            //ready for the autodrive part
        }

    }
}
