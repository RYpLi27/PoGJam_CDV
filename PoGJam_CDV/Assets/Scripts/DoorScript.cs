using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{
    [SerializeField] private string nameScene;
    [SerializeField] private CursedCounter _CursedCounter;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (_CursedCounter.CountCurseObjects() == 0)
                SceneManager.LoadScene(nameScene);
        }
    }
}
