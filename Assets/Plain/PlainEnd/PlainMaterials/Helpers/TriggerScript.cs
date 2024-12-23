using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public GameObject imageObject; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            Debug.Log("AAA");
            ShowImage();
        }
    }

    private void ShowImage()
    {
        if (imageObject != null)
        {
            imageObject.SetActive(true); 
        }
    }
}
