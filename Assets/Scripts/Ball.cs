using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal.Internal;

public class Ball : MonoBehaviour
{    
    public Move mv;
    private Vector2 InitialSpeed = new Vector2 (3,10);
    public Rigidbody2D rb;
    private bool IsMoving = false;
    public AudioClip[] clips;

    private AudioSource audioSource;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {   
        float StartMove = Input.GetAxis("Horizontal");
        if (StartMove != 0 && !IsMoving){
        rb.velocity = InitialSpeed;
        IsMoving = true;
        }
        Count();
        if (Count() <= 0){
        rb.velocity = new Vector2(0,0);
        
        }
        
        if(Input.GetKeyDown(KeyCode.R) ){
        mv.Reload();

        }
        
    }
   void OnCollisionEnter2D(Collision2D other){
            audioSource.Play();
        if(other.gameObject.tag=="brick-o")
        {
            Destroy(other.gameObject);
        }
        else if(other.gameObject.tag=="GameOver"){

            Destroy(rb.gameObject);

        }

   }
    public int Count(){
        GameObject [] Bricks= GameObject.FindGameObjectsWithTag("brick-o");
        int countBricks = Bricks.Length;
        return countBricks;
    }

}
