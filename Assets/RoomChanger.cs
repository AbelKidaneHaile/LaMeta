using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomChanger : MonoBehaviour
{
    public GameObject LivingRoomText;
    public GameObject BedRoomText;
    public GameObject BathRoomText;
    public GameObject TheMainCamera;

    public GameObject livingroomcontainer;
    public GameObject bedroomcontainer;
    public GameObject bathroomcontainer;

    public float x_living = 10.38f;
    public float x_bath = -10.71f;
    public float x_bed = 28.78f;

    public float y = 3.09f;
    public float z = 5.77f;


    public void rightbutton()
    {
        if (LivingRoomText.GetComponent<Renderer>().isVisible)
        {
            LivingRoomText.SetActive(false);
            BedRoomText.SetActive(true);
            TheMainCamera.transform.position = new Vector3(x_bed, y, z);
            livingroomcontainer.SetActive(false);
            bedroomcontainer.SetActive(true);
        }
        else if (BedRoomText.GetComponent<Renderer>().isVisible)
        {
            BedRoomText.SetActive(false);
            BathRoomText.SetActive(true);
            TheMainCamera.transform.position = new Vector3(x_bath, y, z);
            bedroomcontainer.SetActive(false);
            bathroomcontainer.SetActive(true);
        }
        else if (BathRoomText.GetComponent<Renderer>().isVisible)
        {
            BathRoomText.SetActive(false);
            LivingRoomText.SetActive(true);
            TheMainCamera.transform.position = new Vector3(x_living, y, z);
            bathroomcontainer.SetActive(false);
            livingroomcontainer.SetActive(true);
        }

    }


    public void leftbutton()
    {
        if (LivingRoomText.GetComponent<Renderer>().isVisible)
        {
            LivingRoomText.SetActive(false);
            BathRoomText.SetActive(true);
            TheMainCamera.transform.position = new Vector3(x_bath, y, z);
            livingroomcontainer.SetActive(false);
            bathroomcontainer.SetActive(true);
        }
        else if (BedRoomText.GetComponent<Renderer>().isVisible)
        {
            BedRoomText.SetActive(false);
            LivingRoomText.SetActive(true);
            TheMainCamera.transform.position = new Vector3(x_living, y, z);
            bedroomcontainer.SetActive(false);
            livingroomcontainer.SetActive(true);
        }
        else if (BathRoomText.GetComponent<Renderer>().isVisible)
        {
            BathRoomText.SetActive(false);
            BedRoomText.SetActive(true);
            TheMainCamera.transform.position = new Vector3(x_bed, y, z);
            bathroomcontainer.SetActive(false);
            bedroomcontainer.SetActive(true);
        }

    }
    
}
