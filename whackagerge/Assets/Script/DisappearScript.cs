using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearScript : MonoBehaviour
{

        public AudioSource squeak;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnMouseDown(){
        gameObject.SetActive(false);
        if (squeak.isPlaying == false){
            squeak.pitch = Random.Range(0.8f, 1.3f);
            squeak.volume = Random.Range(0.3f, 1f);
            squeak.Play();
            
        }  

    }
}
