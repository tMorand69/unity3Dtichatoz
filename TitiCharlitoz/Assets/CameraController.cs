using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //public GameObject player;
    private Vector3 offset;
    public float turnSpeed = 4.0f;
    public Transform player;
    public float xaxis = -1.85f;
    public float yaxis = 0.77f;
    public float zaxis = -5.52f;


    // Start is called before the first frame update
    void Start()
    {
        //offset = new Vector3(player.position.x + xaxis, player.position.y + yaxis, player.position.z + zaxis);
    }

    // Update is called once per frame
    void Update()
    {
        //offset = new Vector3(player.position.x + xaxis, player.position.y + yaxis, player.position.z + zaxis);

    }

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        //offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offset;
        //transform.position = player.position + offset;
        //transform.LookAt(player.position);
    }
}
