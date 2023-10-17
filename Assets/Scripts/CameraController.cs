using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    Transform _Transform;

    // Start is called before the first frame update
    void Start()
    {
        _Transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = new Vector3(player.position.x, player.position.y, _Transform.position.z);
        _Transform.position = playerPos;
    }
}
