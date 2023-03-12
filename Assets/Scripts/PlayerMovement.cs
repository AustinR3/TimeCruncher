using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float speed;
    public float jump;
    private float Move;
    public Rigidbody2D rb;
    public bool isJumping;
    private Animator anim;
    private SpriteRenderer sprite;

    private enum MovementState { idle, running, jumping, falling }
    
    [SerializeField] private AudioSource jumpSoundEffect;

void Start() 
{
    
anim = GetComponent<Animator>(); 
sprite = GetComponent<SpriteRenderer>();

}

void Update() 
{

Move = Input.GetAxis("Horizontal");

rb.velocity = new Vector2(speed * Move, rb.velocity.y);


if(Input.GetButtonDown("Jump") && isJumping == false)
{

rb.AddForce(new Vector2(rb.velocity.x, jump));
jumpSoundEffect.Play();

}


UpdateAnimation();

}



private void UpdateAnimation()
{

    MovementState state;

if (Move > 0f)
{
    state = MovementState.running;
    sprite.flipX = false;
    
}

else if (Move < 0f)
{
    state = MovementState.running;
    sprite.flipX = true;
}
else 
{
    state = MovementState.idle;
}

if (rb.velocity.y > .1f)
{
    state = MovementState.jumping;
}
else if (rb.velocity.y < -.1f)
{
    state = MovementState.falling;
}

anim.SetInteger("state", (int)state);

}







private void OnCollisionEnter2D(Collision2D other) 
{
    if (other.gameObject.CompareTag("Floor"))
    {
        isJumping = false; 
    }
}

private void OnCollisionExit2D(Collision2D other) 
{
    if (other.gameObject.CompareTag("Floor"))
    {
        isJumping = true;
    }
}




}

