using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float speed;
    private ACT vezzel;
    private Rigidbody rb;

    void Start()
    {
        vezzel.Enable();
        rb = GetComponent<Rigidbody>();
    }

    public void Awake()
    {
        vezzel = new ACT();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        Vector2 direction = vezzel.Player.Move.ReadValue<Vector2>();
        rb.AddForce(direction * speed);
    }
}
