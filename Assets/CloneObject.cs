using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneObject : MonoBehaviour
{

    public GameObject LivingRoomText;
    public GameObject BedRoomText;
    public GameObject BathRoomText;

    public float x_living = 10.38f;
    public float x_bath = -10.71f;
    public float x_bed = 28.78f;

    public float y = 3.09f;
    public float z = 10.77f;

    public GameObject originalObject; // assign the original game object in the Inspector

    public void ClonemyObject()
    {
        GameObject clone = Instantiate(originalObject);

        if (LivingRoomText.GetComponent<Renderer>().isVisible)
        {
            clone.transform.position = new Vector3(x_living, y, z); // set the position of the clone

        }
        else if (BedRoomText.GetComponent<Renderer>().isVisible)
        {
            clone.transform.position = new Vector3(x_bed, y, z); // set the position of the clone

        }
        else if (BathRoomText.GetComponent<Renderer>().isVisible)
        {
            clone.transform.position = new Vector3(x_bath, y, z); // set the position of the clone

        }
        clone.transform.rotation = Quaternion.identity;// set the rotation of the clone
        clone.SetActive(true);

    }
    
}
