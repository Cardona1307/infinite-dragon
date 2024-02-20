using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    [SerializeField] private Transform controladorDisparo;
    [SerializeField] private GameObject fire;
    private Animator dragonAnimator;  // Referencia al Animator

    private void Start()
    {
        dragonAnimator = GetComponent<Animator>();  // Obt�n el componente Animator
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            // Dispara
            Invoke("Disparar", 0.13f);
            // Activa la animaci�n "ataque"
            dragonAnimator.SetTrigger("ataque");
        }
    }

    private void Disparar()
    {
        Instantiate(fire, controladorDisparo.position, controladorDisparo.rotation);
    }
}
