using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{

    private float maxWidth;
    private float maxHeight;

    public Camera cam;

    public float timeLeft;
    public Text timeText;

    public Text pointsText;
    private int points;

    public GameObject copyofhead;
    public GameObject copyoMAN;
    public GameObject copyofLADY;
    public GameObject copyofBUG;

    public GameObject head;
    private bool playing;

    public GameObject cPick;
    public int characterRIGHT;

    // Start is called before the first frame update
    void Start()
    {
        if (cam == null){
            cam = Camera.main;
        }
        playing = false;
        Vector3 upperCorner = new Vector3 (Screen.width , Screen.height , 0.0f);
        Vector3 maxWidthPosition = cam.ScreenToWorldPoint (upperCorner);
        float lhWidth = head.GetComponent<Renderer>().bounds.extents.x;
        maxWidth = maxWidthPosition.x - lhWidth;
        maxHeight = maxWidthPosition.y - lhWidth;

        cPick = GameObject.FindWithTag("Option");
        characterRIGHT = checkChar();
        playing = true;

        if (characterRIGHT == 1) {
                copyofhead = copyoMAN;
                InvokeRepeating("spwMAN", 2.0f, 1f);
                //MAN
        }
        if (characterRIGHT == 2) {
                copyofhead = copyofLADY;
                InvokeRepeating("spwLADY", 2.0f, 1f);
                //LADY
        }
        if (characterRIGHT == 3) {
            copyofhead = copyofBUG;
            InvokeRepeating("spwBUG", 2.0f, 1f);
            //BUG
        }
        if (characterRIGHT == 4) {
            copyofhead = copyofhead;
                InvokeRepeating("spwGerge", 2.0f, 1f);
                //GERGE
        }
        

        points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);  

            if (hit.collider != null) {
                GameObject destroi = hit.collider.gameObject;
                Destroy(destroi);
            }
         }
    }
    void updateText (){
        timeText.text = "Time Left: " + Mathf.RoundToInt(timeLeft); 
        pointsText.text = "Points: " + points;
    }

    void FixedUpdate (){
        //StartCoroutine( StartGameLogic());
        if (playing){
            timeLeft -= Time.deltaTime;

        if (timeLeft < 0){
            playing = false;
            timeLeft = 0;
        }
        updateText();
        }

     
    }

    private void spwGerge (){
        if (playing){
            
            Vector3 spawnPosition = new Vector3 (Random.Range (- maxWidth , maxWidth), Random.Range( - maxHeight , maxHeight),0.0f);

            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(copyofhead, spawnPosition , spawnRotation);
            
    
        }
        
    }
    private void spwMAN (){
        if (playing){
            
            Vector3 spawnPosition = new Vector3 (Random.Range (- maxWidth , maxWidth), Random.Range( - maxHeight , maxHeight),0.0f);

            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(copyofhead, spawnPosition , spawnRotation);
            
    
        }
        
    }
    private void spwLADY (){
        if (playing){
            
            Vector3 spawnPosition = new Vector3 (Random.Range (- maxWidth , maxWidth), Random.Range( - maxHeight , maxHeight),0.0f);

            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(copyofhead, spawnPosition , spawnRotation);
            
    
        }
        
    }
    private void spwBUG (){
        if (playing){
            
            Vector3 spawnPosition = new Vector3 (Random.Range (- maxWidth , maxWidth), Random.Range( - maxHeight , maxHeight),0.0f);

            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(copyofhead, spawnPosition , spawnRotation);
            
    
        }
        
    }
    

    public int checkChar(){
        int option = cPick.GetComponent<CharacterChoice>().getChoice();
        return option;
    }
        


}
