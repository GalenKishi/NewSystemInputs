using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCam : MonoBehaviour
{
    Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent <Camera> ();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.touchCount > 0 && Input.GetTouch(index: 0).phase == TouchPhase.Began)
        {
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                hit.collider.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
            }
        }*/
    }
#if UNITY_EDITOR //Solamente lee el codigo para compilar estas partes en Unity, como tambien hay mas.

#else

#endif
}
