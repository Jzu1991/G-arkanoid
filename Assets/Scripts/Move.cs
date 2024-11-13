using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Move : MonoBehaviour
{   
    public float Speed = 5.0f;
    private bool canMove = true;
    public GameObject ball;
    private AudioSource audioSource;

     void Start()
    {
        
    }

    void Update()
    {   if(!ball){
        canMove = false;
        if(Input.GetKeyDown(KeyCode.R) ){
            Reload();
        }
        }
        if (canMove){
        float hMove = Input.GetAxis("Horizontal");
        Vector3 Movement = new Vector3 (hMove,0,0);
        transform.Translate(Movement*Speed*Time.deltaTime);}

    }
    public void Reload(){
        string actualScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(actualScene);
    }
    
}
