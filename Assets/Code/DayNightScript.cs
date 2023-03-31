using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DayNightScript : MonoBehaviour
{
    public Material skyMaterialDay;
    public Material skyMaterialNight;
    public bool IsNight = true;

    //post processing object day and night
    public GameObject Night;
    public GameObject Day;

    //fireplace light
    public GameObject FireplaceNight;
    public GameObject FireplaceDay;

    //Change lantern material
    //public Material On;
    //public Material Off;
    //public GameObject Lantern;


    void Start()
    {
        //Object.GetComponent<MeshRenderer>().material = On;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsNight == true && (Input.GetKeyDown(KeyCode.P)))
        {
            RenderSettings.skybox = skyMaterialDay;
            IsNight = false;
            
            Day.SetActive(true);
            Night.SetActive(false);

            FireplaceNight.SetActive(false); 
            FireplaceDay.SetActive(true);
        }

        else if (IsNight == false && (Input.GetKeyDown(KeyCode.P)))
        {
            RenderSettings.skybox = skyMaterialNight;
            IsNight = true;
            
            Day.SetActive(false);
            Night.SetActive(true);

            FireplaceNight.SetActive(true);
            FireplaceDay.SetActive(false);
        }
    }
}
