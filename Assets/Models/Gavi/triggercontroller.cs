using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggercontroller : MonoBehaviour
{
    public Animator animator;
    void Start()
    {
        Animator animator = GetComponent<Animator>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Suelo")) // Asegúrate de que el suelo tenga este tag
        {
            animator.SetTrigger("contact");
        }
    }
}
