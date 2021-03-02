using UnityEngine;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour
{
    public float Delay = 2f;
    bool gameends = false;

    public void Completelevel()
    {
        Debug.Log("Next level");
    }
    public void Endgame()
    {
        if (gameends == false)
        {
            gameends = true;
            Debug.Log("Game Over");
            Invoke("Restart", Delay);
        }

       
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
