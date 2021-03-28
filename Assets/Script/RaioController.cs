using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaioController : MonoBehaviour {

   public GameObject explosao;

    private void OnCollisionEnter(Collision other) {
        var hit = other.gameObject;

        Destroy(gameObject);

        if (hit.CompareTag("Inimigo")) {
            var ev = (GameObject) Instantiate( explosao, hit.transform.position, hit.transform.rotation );
            Destroy(hit);
            Destroy(ev, 10);
        }
    }
}
