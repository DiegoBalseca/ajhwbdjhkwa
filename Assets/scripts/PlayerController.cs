using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed = 4.5f;
    public int direction = 1;
    private float InputHorizontal;
    public Rigidbody2D rigidbody; 
    public float jumpForce = 10;
    public groundsensor groundSensor;
   
    void Awake()
    { 
        rigidbody = GetComponent<Rigidbody2D>();
        groundSensor = GetComponentInChildren<groundsensor>();   
    }

    

    // Start is called before the first frame update
    void Start()
    {
        // teletransporta al personaje
        //transform.position = new Vector3 (0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        InputHorizontal = Input.GetAxisRaw ("Horizontal");
      // movimiento  transform.position = new Vector3 (transform.position.x + direction *  playerSpeed * time.deltaTime, transform.position.y, transform.position.y);
      //transform. Translate new Vector3 * 
      // movimiento transfom.position = Vector2. MoveTowards transform.position new Vector2 (transform.position.x + InputHorizontal), playerSpeed * Time deltaTime;
      
      if(Input.GetButtonDown("Jump") && groundSensor.isgrounder)
      {
        rigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
      }

      
    }

    void FixedUpdate()
        {
        rigidbody.velocity = new Vector2 (InputHorizontal * playerSpeed, rigidbody.velocity.y);
       // rigidbody2D.AddForce(new Vector2(InputHorizontal, 0));   
       //rigidbody.MovePosition new Vector2) 
        }
}