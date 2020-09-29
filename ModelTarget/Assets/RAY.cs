using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class RAY : MonoBehaviour
{
    public GameObject can2;

    private void Start()
    {
        VirtualButtonBehaviour vb = GetComponent<VirtualButtonBehaviour>();

        vb.RegisterOnButtonPressed(hello);
    }

    void hello(VirtualButtonBehaviour v)
    {

    }

    void FixedUpdate()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            Ray ray = Camera.main.ScreenPointToRay(touch.position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                string name = hit.rigidbody.name;
                if(name == "Image")
                {
                    can2.SetActive(true);
                }
            }
        }
    }
}
