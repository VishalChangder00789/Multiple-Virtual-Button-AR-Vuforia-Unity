using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class placeYoda : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject PlaceYodaButton;
    public GameObject Cube;
    public GameObject yodaPrefab;
    public Material[] preAppliedMaterials;
    int randomMaterial = Random.Range(0, 14);

    private Renderer render;


    private GameObject newModel;

    void Start()
    {
        PlaceYodaButton = GameObject.Find("PlaceYoda");
        PlaceYodaButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        newModel = yodaPrefab;
        render = newModel.GetComponent<Renderer>();


    }

    public void OnButtonPressed(VirtualButtonBehaviour vb3)
    {
        setMaterial();
        Cube.SetActive(false);
        
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb3)
    {
        Cube.SetActive(true);
    }

    void setMaterial()
    {
        for(int i = 0; i < 14; i++)
        {
            render.sharedMaterials[i] = preAppliedMaterials[randomMaterial];
        }
        Instantiate(newModel, Cube.transform.position, Cube.transform.rotation);
        Debug.Log("Yoda Instantiated");
    }


}
