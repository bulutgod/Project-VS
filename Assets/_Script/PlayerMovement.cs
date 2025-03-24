using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEditor.Tilemaps;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class PlayerMovement : MonoBehaviour
{
    public float movespeed = 5f;
    private Rigidbody2D rb;
    private Vector2 input;
    private bool facingRight = true;
    public Vector2 direction;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        Movement();
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + input * movespeed * Time.fixedDeltaTime);
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }

    void Movement()
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");

        direction = new Vector2(input.x, input.y).normalized;

        if (input.x > 0 && !facingRight)
        {
            Flip();
        }
        else if (input.x < 0 && facingRight)
        {
            Flip();
        }
    }
}

