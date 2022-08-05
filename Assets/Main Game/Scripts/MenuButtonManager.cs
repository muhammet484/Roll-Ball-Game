
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonManager : MonoBehaviour
{
    public void PlayButtonOnClickEvent()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitButtonOnclickEvent()
    {
        Application.Quit();
    }
}
