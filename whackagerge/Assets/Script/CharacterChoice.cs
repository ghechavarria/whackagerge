using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterChoice : MonoBehaviour
{
    public int chaChoice = 0;
    // Start is called before the first frame update
    void Awake()
    {
    

        DontDestroyOnLoad(this.gameObject);
    }


    public void changeValueOptionONE( ){
   
        this.chaChoice = 1;
        Debug.Log(chaChoice);
        
        
    }
    public void changeValueOptionTWO( ){
       
            this.chaChoice = 2;
        Debug.Log(chaChoice);
        
    }
    public void changeValueOptionTHREE( ){
        
            this.chaChoice = 3;
        Debug.Log(chaChoice);
        
    }
    public void changeValueOptionFOUR( ){
      
            this.chaChoice = 4;
        Debug.Log(chaChoice);
        
    }

    public int getChoice (){
        return this.chaChoice;
    }


}
