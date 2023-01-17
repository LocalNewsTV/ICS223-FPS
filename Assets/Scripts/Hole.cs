using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    private int[,] positions = new int[,]{{-17,1,20},{17,1,20},{-17,1,-20}};
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
        void OnCollisionEnter(Collision collision){
            if(collision.gameObject.tag == "Ball"){
                int rand = Random.Range(0,100) % 3;
                int x = positions[rand,0];
                int y = positions[rand,1];
                int z = positions[rand,2];
                collision.transform.position = new Vector3(x,y,z);
                // Destroy(collision.gameObject);
        }
    }
}
