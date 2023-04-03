using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbiter : MonoBehaviour
{
    public Transform earth;
    public float rotationSpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        earth.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the Earth
        earth.Rotate(new Vector3(0, rotationSpeed * Time.deltaTime, 0), Space.World);
    }
}
