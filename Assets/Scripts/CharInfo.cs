using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharInfo : MonoBehaviour
{
    public GameObject panel1, panel2, panel3, nextButton, backButton;

    private void Start()
    {
        panel3.SetActive(false);
        panel2.SetActive(false);
        panel1.SetActive(true);
    }

    public void NextPanel()
    {
        if (panel1.activeInHierarchy)
        {
            panel1.SetActive(false);
            panel2.SetActive(true);
            panel3.SetActive(false);
            //backButton.SetActive(true);
            backButton.GetComponent<Button>().interactable = true;
        }
        else if (panel2.activeInHierarchy)
        {
            panel3.SetActive(true);
            panel2.SetActive(false);
            panel1.SetActive(false);
            //nextButton.SetActive(false);
            //nextButton.GetComponent<Button>().interactable = false;
            nextButton.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "End";
        }
        else if (panel3.activeInHierarchy)
        {
            NextScene();
        }
    }

    void NextScene()
    {
        print("yeni oyun sahnesine geçildi");
        //SceneManager.LoadScene(2);
        if(SceneManager.GetActiveScene().buildIndex < 2)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        else if (SceneManager.GetActiveScene().buildIndex == 2)
            SceneManager.LoadScene(0);
    }

    public void BackPanel()
    {        
        if (panel2.activeInHierarchy)
        {
            panel3.SetActive(false);
            panel2.SetActive(false);
            panel1.SetActive(true);
            //backButton.SetActive(false);
            backButton.GetComponent<Button>().interactable = false;
        }    
        else if (panel3.activeInHierarchy)
        {
            panel3.SetActive(false);
            panel2.SetActive(true);
            panel1.SetActive(false);
            //nextButton.SetActive(true);
            //nextButton.GetComponent<Button>().interactable = true;
            nextButton.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Next";
        }
    }

    public void CubeClick()
    {
        print("fizik objesine tikladim");
    }
}
