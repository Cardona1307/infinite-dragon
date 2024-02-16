using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragon : MonoBehaviour
{
    [SerializeField] private float upForce;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask ground;
    [SerializeField] private float radius;

    private Rigidbody2D dragonRb;

    void Start()
    {
        dragonRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        bool isGrounded = Physics2D.OverlapCircle(groundCheck.position, radius, ground);

        if (isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                dragonRb.AddForce(Vector2.up * upForce);
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(groundCheck.position, radius);
    }
}
