using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public float speed = 20;
    // ranges set for clamping position
    public float xRange = 35;
    public float zRange = 25;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");
        // the offset is made based on movement speed
        float xOffset = horizontalMove * speed * Time.deltaTime;
        float zOffset = verticalMove * speed * Time.deltaTime;
        // raw positions for X and Z are made before adjusting to clamp values
        float rawXPos = transform.position.x + xOffset;
        float clampedXPos = Mathf.Clamp(rawXPos, -xRange, xRange);
        float rawZPos = transform.position.z + zOffset;
        float clampedZPos = Mathf.Clamp(rawZPos, -zRange, zRange);
        // actual movement is made based on clamps
        transform.position = new Vector3(clampedXPos, transform.position.y, clampedZPos);
    }
}
