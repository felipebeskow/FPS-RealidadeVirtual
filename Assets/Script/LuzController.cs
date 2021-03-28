using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuzController : MonoBehaviour {
    public Transform player;
    void FixedUpdate() {
        var x = player.transform.position.x;
        var z = player.transform.position.z;

        transform.position = new Vector3( x, 3, z );
    }
}
