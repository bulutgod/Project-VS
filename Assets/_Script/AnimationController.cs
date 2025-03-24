using System.Collections;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private PlayerMovement playerMovement;
       
    void Start()
    {
        
    }

    
    void Update()
    {
        walkAnim();
        attackAnim();
    }

    void walkAnim()
    {
        if (playerMovement.direction.magnitude >= 0.1f )
        {
            animator.SetBool("isWalking" , true);
        }
        else if (playerMovement.direction.magnitude <= 0.1f)
        {
            animator.SetBool("isWalking", false);
        }
    }
    void attackAnim()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("isAttack");
        }
      
    }
 //state pattern
}
