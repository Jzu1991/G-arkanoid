using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miau : MonoBehaviour
{
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    void OnCollisionEnter2D(Collision2D other){
        
        if(other.gameObject.tag=="Ball")
        {
            Debug.Log("perdiste");
            audioSource.Play();
        }
}
}
