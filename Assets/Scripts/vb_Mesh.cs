using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb_Mesh : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject buttonForGeneration;
    public GameObject YourModel;
    public Transform SpawnPoint;

    private GameObject cloneObject;

    void Start()
    {
        buttonForGeneration = GameObject.Find("MeshButton");
        buttonForGeneration.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb4)
    {
        cloneObject = Instantiate(YourModel, SpawnPoint.transform);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb4)
    {
        cloneObject.SetActive(false);
    }
}