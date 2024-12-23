using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    public Button button1; 
    public Button button2; 

    void Start()
    {
        if (button1 != null)
        {
            button1.onClick.AddListener(OnButton1Click);
        }

        if (button2 != null)
        {
            button2.onClick.AddListener(OnButton2Click);
        }
    }

    void OnButton1Click()
    {
        Debug.Log("Button 1 clicked!");
        SceneManager.LoadScene(1);
    }

    void OnButton2Click()
    {
        Debug.Log("Button 2 clicked!");
        Application.Quit();
    }
}
