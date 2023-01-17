using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    public float moveSpeed = 10.0f;
    // Start is called before the first frame update
    void Start(){
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate(){
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition + Vector3.forward * 10f);
        float angle = AngleBetweenPoints(transform.position, mouseWorldPosition);
        transform.rotation = Quaternion.Euler(new Vector3(0f,angle,0f));
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        // transform.Translate(new Vector3(horizontalInput, 0, verticalInput ) * moveSpeed * Time.deltaTime);
        rb.velocity = new Vector3(horizontalInput, 0, verticalInput) * moveSpeed;
    }
         
     float AngleBetweenPoints(Vector2 a, Vector2 b) {
         return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
     }
}
