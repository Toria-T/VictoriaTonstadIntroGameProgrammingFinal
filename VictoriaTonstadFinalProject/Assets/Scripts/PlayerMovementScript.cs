using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    public int Speed = 5; //player speed
    private Rigidbody rigidbody;
    // Start is called before the first frame update
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>(); //checks for rigidbody component
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal") * Speed, rigidbody.velocity.y, Input.GetAxis("Vertical") * Speed); //Controls the rigidbody. It already assumes the controls
    }
}
