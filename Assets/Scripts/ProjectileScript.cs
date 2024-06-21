using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public int Damage = 1;
    public int ProjectileSpeed = 10;
    float interval = 0f;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(gameObject.transform.right * ProjectileSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        interval += Time.deltaTime;
        if (interval > 3) Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D Other)
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<EnemyScript>().GetDamage(Damage);
            Destroy(gameObject);
        }
    }
}