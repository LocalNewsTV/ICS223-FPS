using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Lazer : MonoBehaviour
{
    public float speed = 9f;
    private void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerCharacter player = other.GetComponent<PlayerCharacter>();
        if(player != null)
        {
            player.Hit();
        }
        Destroy(this.gameObject);
    }
}
