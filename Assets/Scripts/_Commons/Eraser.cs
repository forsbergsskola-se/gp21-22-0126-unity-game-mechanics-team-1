using UnityEngine;
using UnityEngine.SceneManagement;

public class Eraser : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Destroy(other.gameObject);
        if (other.gameObject.CompareTag("Player")) SceneManager.LoadScene("MainScene");
    }
}
