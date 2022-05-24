using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class CBTButtonManager : MonoBehaviour
{
    public GameObject HelpPopUp;
    public GameObject BackgroundScene;
    public TextMeshProUGUI situationtext;
    public GameObject EndPanel;

    public void GoToNext()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void GoToIntro()
    {
        SceneManager.LoadScene("Intro help");
    }
        
    public void GoToNegativeHelp()
    {
        SceneManager.LoadScene("Negative help");
    }

    public void GoToPositiveHelp()
    {
        SceneManager.LoadScene("Positive help scene");
    }

    public void GoToCbtInstructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void GoToInstructionPopup()
    {
        SceneManager.LoadScene("5 Instruction Popup");
    }

    public void GoToPlayerInput()
    {
        SceneManager.LoadScene("6 Player Input");
    }

    public void GoToCloseUp()
    {
        SceneManager.LoadScene("Close Up Scene");
    }

    public void ToggleHelp()
    {
        bool HelpIsActive = HelpPopUp.activeSelf;
        bool BackgroundIsActive = BackgroundScene.activeSelf;

        HelpPopUp.SetActive(!HelpIsActive);
        BackgroundScene.SetActive(!BackgroundIsActive);
    }

    public void selectPositive()
    {
        situationtext.text = "SITUATION: (POSITIVE)";
    }

    public void selectNegative()
    {
        situationtext.text = "SITUATION: (NEGATIVE)";
    }

    public void TakeScreenShot()
    {
        ScreenCapture.CaptureScreenshot(System.DateTime.Now.ToString().Replace('/', '-')+".png");
        EndPanel.SetActive(true);
        GameData.coins += 50f;
    }
}
