using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Config")]
    [SerializeField] private float speed;

    private PlayerActions actions;
    private Rigidbody2D rb2D;
    private Vector2 moveDirection;
    private Animator animator;
    private readonly int moveX = Animator.StringToHash("MoveX");
    private readonly int moveY = Animator.StringToHash("MoveY");

    private void Awake()
    {
        actions = new PlayerActions();
        rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    
    void Update()
    {
        ReadMovement();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        rb2D.MovePosition(rb2D.position + moveDirection * (speed * Time.fixedDeltaTime));
    }

    private void ReadMovement()
    {
        moveDirection = actions.Movement.Move.ReadValue<Vector2>().normalized;
        if (moveDirection == Vector2.zero)
            return;
        // If moveDirection vector is equals to zero (that's mean our character not moving) don't do anything, just return and go to the next function/code block

        // Update Parameters
        animator.SetFloat(moveX, moveDirection.x);
        animator.SetFloat(moveY, moveDirection.y);
    }

    private void OnEnable()
    {
        actions.Enable();
    }

    private void OnDisable()
    {
        actions.Disable();
    }
}
