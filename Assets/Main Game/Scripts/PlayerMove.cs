using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float SpeedMultiplier;
    [SerializeField] float MaxSpeed;

    [SerializeField] float JumpForce;
    [SerializeField] float Gravity = -9.81f;

    [SerializeField] float SlowingMultiplier;

    [SerializeField] Rigidbody rb;

    private bool isGrounded = true;
    #region keys
    KeyCode UpKey = KeyCode.W;
    KeyCode DownKey = KeyCode.S;
    KeyCode LeftKey = KeyCode.A;
    KeyCode RightKey = KeyCode.D;

    KeyCode JumpKey = KeyCode.Space;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        #region Move at X and Y
        if (Input.GetKey(UpKey))
        {
            RBGo(0, 1);
        }
        if (Input.GetKey(DownKey))
        {
            RBGo(0, -1);
        }
        if (Input.GetKey(LeftKey))
        {
            RBGo(-1, 0);
        }
        if (Input.GetKey(RightKey))
        {
            RBGo(1, 0);
        }
        #endregion
        if (Input.GetKeyDown(JumpKey) && isGrounded)
        {
            rb.velocity = ( new Vector3(rb.velocity.x,
                Mathf.Sqrt(JumpForce * -2f * Gravity),
                rb.velocity.z
                ));
        }

        //use gravity:
        //rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y + Gravity, rb.velocity.z);
        rb.AddForce(Vector3.up * Gravity);

        //slow down in air and ground
        //rb.AddForce((delY(rb.velocity) * -1).normalized * SlowingMultiplier);
    }

    void RBGo(float x, float y)
    {
        #region move by adding Force
        /*
        Vector3 RBV = new Vector3(rb.velocity.x, 0, rb.velocity.z);

        if(RBV.magnitude < MaxSpeed)
        {
            rb.AddForce(new Vector3(x, 0, y) * SpeedMultiplier);
        }*/
        #endregion

        rb.velocity = new Vector3(
            x != 0 ? x * SpeedMultiplier : rb.velocity.x, 
            rb.velocity.y,
            y != 0 ? y * SpeedMultiplier : rb.velocity.z);
    }


    public static Vector3 delY(Vector3 vector3)
    {
        return new Vector3(vector3.x, 0, vector3.z);
    }
}
