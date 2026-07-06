using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadSimulation()
    {
        SceneManager.LoadScene("SimulationMode");
    }

    public void LoadMissionControl()
    {
        SceneManager.LoadScene("MissionControl");
    }

    public void LoadExploration()
    {
        SceneManager.LoadScene("ExploreMode");
    }
}