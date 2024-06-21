using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour
{
    public FloatingJoystick Joystick;
    float Angle;
    public GameObject Projectile;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Angle = Mathf.Atan2(Joystick.Direction.normalized.y, Joystick.Direction.normalized.x) * Mathf.Rad2Deg;
        if (Angle != 0) transform.rotation = Quaternion.Euler(0f, 0f, Angle);

        if (Input.GetKeyDown(KeyCode.Z))
        {
            GameObject insBullet = Instantiate(Projectile);
            insBullet.transform.position = this.transform.position;
            insBullet.transform.up = this.gameObject.transform.up;
        }
    }

    public void OnClickAttack()
    {
        GameObject insBullet = Instantiate(Projectile);
        insBullet.transform.position = this.transform.position;
        insBullet.transform.up = this.gameObject.transform.up;
    }
}