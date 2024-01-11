using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementChecker : MonoBehaviour
{
    [SerializeField] private float minVel = 0.1f;
    private Rigidbody rb;
    private HeroRotacion hr;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        hr = GetComponent<HeroRotacion>();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsMoving())        
            hr.enabled = true;      
        else
            hr.enabled = false;
    }
    bool IsMoving()
    {
        return rb.velocity.magnitude > minVel;
    }
}
