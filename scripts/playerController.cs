using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class playerController : MonoBehaviour
{
  private Rigidbody rb;
    private Animator animator;
    public bool isDead;
    public AudioSource aS;
    public AudioClip death;
    public AudioClip jump;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        aS = GetComponent<AudioSource>();
    }

  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isDead)
        {
            rb.AddForce(Vector3.up * 10, ForceMode.Impulse);
            aS.PlayOneShot(jump);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        isDead = true;
        animator.SetTrigger("Die");
        aS.PlayOneShot(death);
    }
}
