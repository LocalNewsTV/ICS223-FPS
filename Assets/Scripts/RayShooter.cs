using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.SceneManagement;
using UnityEngine;

public class RayShooter : MonoBehaviour
{
    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();

    }

    private IEnumerator SphereIndicator(Vector3 hitPosition)
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        sphere.transform.position = hitPosition;
        yield return new WaitForSeconds(1);

        Destroy(sphere);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 point = new Vector3(cam.pixelWidth / 2, cam.pixelHeight / 2, 0);
            Ray ray = cam.ScreenPointToRay(point);
            RaycastHit hit;
            if (Physics.Raycast (ray, out hit))
            {
                GameObject hitObject = hit.transform.gameObject;
                ReactiveTarget target = hitObject.GetComponent<ReactiveTarget>();
                if(target != null)
                {
                    target.ReactToHit();
                } else
                {
                    StartCoroutine(SphereIndicator(hit.point));
                }
                //Visually Indicate the hit
                StartCoroutine(SphereIndicator(hit.point));
            }
        }
    }
}
