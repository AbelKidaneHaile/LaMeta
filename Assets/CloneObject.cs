using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneObject : MonoBehaviour
{

    public GameObject originalObject; // assign the original game object in the Inspector

    public void ClonemyObject()
    {
        GameObject clone = Instantiate(originalObject); 
        clone.transform.position = new Vector3(0, 0, 0); // set the position of the clone
        clone.transform.rotation = Quaternion.identity; // set the rotation of the clone
        //Debug.Log("Clone Created!");
    }
   
   
}
