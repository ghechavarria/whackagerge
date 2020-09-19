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

    private GameObject copyofhead;

    public GameObject head;
    private bool playing;

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
        copyofhead = head;
        playing = true;
        InvokeRepeating("spwGerge", 2.0f, 1f);

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
    


}
