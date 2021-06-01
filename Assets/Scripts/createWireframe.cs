using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class createWireframe : MonoBehaviour,IVirtualButtonEventHandler
{

    public GameObject Wireframe;
    public GameObject Cube;
    //public Material[] myMaterials;
    //private Renderer rend;

    void Start()
    {
        Wireframe = GameObject.Find("Wireframe");
        Wireframe.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        GL.wireframe = true;
        //rend.sharedMaterial = myMaterials[0];
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        GL.wireframe = false;

        //rend.sharedMaterial = myMaterials[1];
    }
}
