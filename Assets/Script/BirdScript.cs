using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    private Animator anim;
    [SerializeField] private AudioSource flySoundEffect;
    [SerializeField] private AudioSource deathSoundEffect;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -25 || transform.position.y > 25)
        {            
            logic.gameOver();
            birdIsAlive = false;
            Destroy(gameObject);
            
        }
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            flySoundEffect.Play();
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        deathSoundEffect.Play();
        anim.SetTrigger("death");
        logic.gameOver();
        birdIsAlive = false;

    }
}