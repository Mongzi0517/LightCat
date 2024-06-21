using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed =  4.0f;
    public FloatingJoystick Joystick;

    Rigidbody2D PlayerRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        PlayerRigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float X = Joystick.Horizontal;
        float Y = Joystick.Vertical;

        Vector3 getVel = new Vector3(X, Y, 0) * MoveSpeed;
        PlayerRigidbody.velocity = getVel;

    }
}