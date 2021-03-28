using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TiroController : MonoBehaviour {

    public Transform localTiro;
    public GameObject tiro;
    public Button voltar;
    public Button menu;

    private void Start() {
        VoltarJogo();
    }

    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            Fogo();
        }
        if (Input.GetKeyDown(KeyCode.Escape)) {
            voltar.gameObject.SetActive(true);
            menu.gameObject.SetActive(true);
        }
    }

    private void Fogo() {
        var bala = (GameObject) Instantiate(tiro, localTiro.position, localTiro.rotation);

        if (bala) {

           bala.GetComponent<Rigidbody>().velocity = bala.transform.forward * 25;

            var sound = GetComponent<AudioSource>();
            if(sound) sound.Play();

            Destroy(bala, 6);

        }
    }

    public void MenuIncial(){
        SceneManager.LoadScene("MenuInicial");
        
    }

    public void VoltarJogo() {
        voltar.gameObject.SetActive(false);
        menu.gameObject.SetActive(false);
    }
}
