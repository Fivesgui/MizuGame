using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuiniciar : MonoBehaviour
{
    [SerializeField]private string nomedoleveldejogo;
    [SerializeField] private GameObject panel;
    public void jogar()
    {
        SceneManager.LoadScene(nomedoleveldejogo);
    }

    public void sairjogo()
    {
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }
    public void menu2()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(nomedoleveldejogo);
        }
    }
}
