using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject cam;

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
    }

    private void FollowPlayer() {
        Vector3 playerPos = gameObject.transform.position;
        float newX = cam.transform.position.x;
        float newY = cam.transform.position.y;

        if (playerPos.x > minX && playerPos.x < maxX) {
            newX = playerPos.x;
        }
        if (playerPos.y > minY && playerPos.y < maxY) {
            newY = playerPos.y;
        }

        cam.transform.position = new Vector3(newX, newY, cam.transform.position.z);
    }
}
