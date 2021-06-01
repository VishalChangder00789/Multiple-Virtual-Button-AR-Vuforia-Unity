using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class materialShader : MonoBehaviour,IVirtualButtonEventHandler
{

    public GameObject MaterialshaderButton;
    public GameObject Cube;
    private Renderer renderObject;
    private Material oldMaterial;
    private float speed = 0.1f;

    public Material[] myMaterial;

    private void Update()
    {
        Cube.transform.Rotate(new Vector3(60,0,90),90*speed/5);
    }

    void Start()
    {
         MaterialshaderButton= GameObject.Find("MaterialShader");
        MaterialshaderButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        renderObject = Cube.GetComponent<Renderer>();

        ///This will store the old material of the cube
        oldMaterial = Cube.GetComponent<Renderer>().material;
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb1)
    {
        ///change the color to the material that use chose :

        int randomMaterial = Random.Range(0, 6);
        renderObject.material = myMaterial[randomMaterial];
        //Rotate the cube.
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb1)
    {
        renderObject.material = oldMaterial;
    }
}
