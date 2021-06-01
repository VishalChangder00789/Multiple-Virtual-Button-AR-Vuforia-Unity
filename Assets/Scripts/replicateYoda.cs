using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class replicateYoda : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject ReplicateYoda;
    public GameObject Cube;
    public GameObject yodaPrefab;
    public float yodaSize;



    void Start()
    {
        ReplicateYoda = GameObject.Find("ReplicateYoda");
        ReplicateYoda.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb2)
    {

        Cube.SetActive(false);

        ///local Declaration
        GameObject model;
        float randomSize = Random.Range(5, 15);
        Vector3 transformPosition = Cube.transform.position - new Vector3(yodaSize * (Random.Range(0, 4)), yodaSize * Random.Range(0, 4), yodaSize * Random.Range(0, 4));

        model = yodaPrefab;
        model.transform.localScale = new Vector3(randomSize, randomSize, randomSize);
        model.AddComponent<Rigidbody>();
        model.GetComponent<Rigidbody>().mass = Random.Range(0, 8);
        Instantiate(model, transformPosition, Cube.transform.rotation);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb2)
    {
        Cube.SetActive(true);
    }
}
