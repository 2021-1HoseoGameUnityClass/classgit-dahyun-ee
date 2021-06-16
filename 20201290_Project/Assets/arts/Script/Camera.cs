using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField]
    // Start is called before the first frame update

    private GameObject playerObj = null;
   
    // Update is called once per frame
    void Update()
    {
        Vector3 vector3 = new Vector3();
        vector3.y = playerObj.transform.position.y;
        vector3.z = -10;
        vector3.x = playerObj.transform.position.x;

        transform.position = vector3;
    }
}
