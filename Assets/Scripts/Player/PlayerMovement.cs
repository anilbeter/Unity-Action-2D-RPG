using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Config")]
    [SerializeField] private float speed;

    private PlayerAnimations playerAnimations;
    private PlayerActions actions;
    private Rigidbody2D rb2D;
    private Vector2 moveDirection;
    private Player player;

    private void Awake()
    {
        player = GetComponent<Player>();
        actions = new PlayerActions();
        rb2D = GetComponent<Rigidbody2D>();
        playerAnimations = GetComponent<PlayerAnimations>();
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
        if (player.Stats.health <= 0f) return;
        rb2D.MovePosition(rb2D.position + moveDirection * (speed * Time.fixedDeltaTime));
    }

    private void ReadMovement()
    {
        moveDirection = actions.Movement.Move.ReadValue<Vector2>().normalized;
        if (moveDirection == Vector2.zero)
        {
            // animator.SetBool(moving, false);
            playerAnimations.SetMoveBoolTransition(false);
            return;
        }
   

        playerAnimations.SetMoveBoolTransition(true);
        playerAnimations.setMoveAnimation(moveDirection);
 
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
