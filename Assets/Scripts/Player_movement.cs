using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_movement : MonoBehaviour
{
    Rigidbody2D Player_rigidbody;
    private Animation_player anime;
    private SpriteRenderer sprite_player;
    [SerializeField] int speed = 3;
    [SerializeField] GameObject ghost;
    
    
    private BoxCollider2D box;
   

    [SerializeField] bool grounded = false;
    [SerializeField] float jump_force = 10;


    // Start is called before the first frame update
    void Start()
    {
        Player_rigidbody = GetComponent<Rigidbody2D>();
       anime = GetComponent<Animation_player>();
        sprite_player = GetComponentInChildren<SpriteRenderer>();
        box = GetComponent<BoxCollider2D>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
            player_movement();
        
        
    }

    private void player_movement()
    {
        float move = Input.GetAxisRaw("Horizontal");
        anime.Run(move);
        flip_player(move);

        if(Input.GetKeyDown(KeyCode.Space)&& grounded == true)
        {
            Player_rigidbody.velocity = new Vector2(Player_rigidbody.velocity.x, jump_force);
            grounded = false;
        }

        RaycastHit2D hitinfo = Physics2D.Raycast(transform.position, Vector2.down, 0.6f,1<<8);
        Debug.DrawRay(transform.position, Vector2.down*0.6f, Color.green);

        

        if(hitinfo.collider !=null)
        {
            grounded = true;
        }
     

        Player_rigidbody.velocity = new Vector2(move*speed, Player_rigidbody.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("enemy"))
        {
            int order = 10;
            Player_rigidbody.velocity = new Vector2(Player_rigidbody.velocity.x, jump_force);
            sprite_player.sortingOrder = order;
            box.enabled = false;
        }
        if (collision.CompareTag("goen"))
        {

            ghost.SetActive(true);
            
        }
    }
 
        
    





    private void flip_player(float move)
    {
        if (move > 0)
        {
            sprite_player.flipX = false;
        }
        else if (move < 0)
        {
            sprite_player.flipX = true;
        }
    }
}
