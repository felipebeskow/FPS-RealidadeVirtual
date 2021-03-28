using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;

public class MenuControler : MonoBehaviour
{
    public Text instrucoes;
    public Button comecar;
    public Button sair;

    public void Comecar() {
        destroyBotoes();
        SceneManager.LoadScene("Historia");
    }

    public void Sair() {
        instrucoes.text = "Até breve!";
        destroyBotoes();
        Application.Quit();
    }

    private void destroyBotoes() {
        comecar.gameObject.SetActive(false);
        sair.gameObject.SetActive(false);
    }

}
