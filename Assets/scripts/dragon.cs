using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class dragon : MonoBehaviour
{
    [SerializeField] private float upForce;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask ground;
    [SerializeField] private float radius;

    private Rigidbody2D dragonRb;
    private Animator dragonAnimator;


    void Start()
    {
        dragonRb = GetComponent<Rigidbody2D>();
        dragonAnimator = GetComponent<Animator> (); 
    }

    void Update()
    {
        bool isGrounded = Physics2D.OverlapCircle(groundCheck.position, radius, ground);
        dragonAnimator.SetBool("isGrounded" , isGrounded);

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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("obstaculo"))
        {
            GameManager.Instance.ShowPantallaMuerte();
            dragonAnimator.SetTrigger("die");
            Time.timeScale = 0f;
        }
    }

}
