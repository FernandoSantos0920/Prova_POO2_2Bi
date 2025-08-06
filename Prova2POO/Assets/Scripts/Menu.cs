using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject panelBase;
    public GameObject panelOptions;
    public GameObject panelVideo;
    public GameObject panelSom;
    public GameObject panelExtras;
    public GameObject panelCredits;
    public GameObject panelControles;
    
    
    public void Play()
    {
        SceneManager.LoadScene("Jogo");
    }

    public void Options()
    {
        panelOptions.SetActive(true);
        panelBase.SetActive(false);
    }

    public void VoltarOptions()
    {
        panelOptions.SetActive(false);
        panelBase.SetActive(true);
    }


    public void Videos()
    {
        panelVideo.SetActive(true);
        panelOptions.SetActive(false);
    }

    public void VoltarVideo()
    {
        panelVideo.SetActive(false);
        panelOptions.SetActive(true);
    }

    public void Som()
    {
        panelSom.SetActive(true);
        panelOptions.SetActive(false);
    }

    public void VoltarSom()
    {
        panelSom.SetActive(false);
        panelOptions.SetActive(true);
    }

    public void Controles()
    {
        panelControles.SetActive(true);
        panelOptions.SetActive(false);
    }

    public void VoltarCOntroles()
    {
        panelControles.SetActive(false);
        panelOptions.SetActive(true);
    }


    public void Extras()
    {
        panelExtras.SetActive(true);
        panelBase.SetActive(false);
    }

    public void VoltarExtras()
    {
        panelExtras.SetActive(false);
        panelBase.SetActive(true);
    }


    public void Credits()
    {
        panelCredits.SetActive(true);
        panelBase.SetActive(false);
    }

    public void VoltarCredits()

    {
        panelCredits.SetActive(false);
        panelBase.SetActive(true);
    }
}
