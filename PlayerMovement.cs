using UnityEngine;
using UnityEngine.Rendering;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 5.0f;

    private Rigidbody2D rb2D;
    private Vector2 movementInput;
    //Todo lo que tenga que ver con animator será implementado cuando tenga los sprites del personaje
    //private Animator animation;

    void Start()
    {
        rb2D  = GetComponent<Rigidbody2D>();
        //animator  =GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        movementInput.x = Input.GetAxisRaw("Horizontal");
        movementInput.y = Input.GetAxisRaw("Vertical");

        movementInput = movementInput.normalized;

        /*
         animator.SetFloat("Horizontal",movementInput.x);
         animator.SetFloat("Vertical",movementInput.y);
         animator.SetFloat("Speed",movementInput.magnitude);*/
    }

    private void FixedUpdate()
    {
        rb2D.linearVelocity = movementInput * speed;
    }



}
