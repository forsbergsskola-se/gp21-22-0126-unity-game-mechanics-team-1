using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("fly script added to: " + gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * 10.0f;
        if (Input.GetKey(KeyCode.F)) transform.position += transform.forward * Time.deltaTime * 40.0f;
        transform.Rotate(Input.GetAxis("Vertical"), 0.0f, -Input.GetAxis("Horizontal"));
        transform.Rotate(-Vector3.up * 15 * Time.deltaTime); //turn left
        transform.Rotate(Vector3.up *15 * Time.deltaTime); //turn right
        

        float terrainHeightWhereWeAre = Terrain.activeTerrain.SampleHeight(transform.position);
        if (terrainHeightWhereWeAre > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, terrainHeightWhereWeAre, transform.position.z);
        }
            
    }
    
}
