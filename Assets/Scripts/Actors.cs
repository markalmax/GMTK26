using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class Actors : MonoBehaviour
{
    public float moveForce;
    public float maxSpeed;
    public Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        
    }
    protected void Move(Vector2 dir)
    {
        if(rb.linearVelocity.magnitude > maxSpeed)
        {
            rb.linearVelocity = rb.linearVelocity.normalized * maxSpeed;
        }
        rb.AddForce(dir*moveForce,ForceMode2D.Force);
    } 
}
