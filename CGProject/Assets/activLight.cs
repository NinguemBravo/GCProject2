using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activLight : MonoBehaviour
{
    [SerializeField]
    private GameObject light;
    [SerializeField]
    private GameObject postFx;
    [SerializeField]
    private GameObject particles;
    private bool lightOn;
    private bool particleOn;
    private bool postFXOn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            lightOn = light.activeInHierarchy;
            light.SetActive(!lightOn);
        }
        if (Input.GetKeyDown("left shift"))
        {
            postFXOn = postFx.activeInHierarchy;
            postFx.SetActive(!postFXOn);
        }
        if (Input.GetKeyDown("left ctrl"))
        {
            particleOn = particles.activeInHierarchy;
            particles.SetActive(!particleOn);
        }
    }
}
