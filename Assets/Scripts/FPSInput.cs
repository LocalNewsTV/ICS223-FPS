using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSInput : MonoBehaviour
{
    [SerializeField] CharacterController charCont;
    private float gravity = -9.8f;
    private float speed = 9.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horiz,0.0f, vert);

        //Limit Diagonal movement
        movement = Vector3.ClampMagnitude(movement, 1.0f);
        //Apply Gravity
        movement.y = gravity;
        //Take speed into account
        movement *= speed;
        //Make processor independent
        movement *= Time.deltaTime;
        //Convert local to global Coordinates
        movement = transform.TransformDirection(movement);

        charCont.Move(movement);
        /*transform.Translate(movement * speed * Time.deltaTime, Space.Self);*/
    }
}
