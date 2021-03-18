using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject roundsSelector;
    private int roundCount = 10;

    private void Start()
    {
        mainMenu.SetActive(true);
        roundsSelector.SetActive(false);
    }

    public void StartSinglePlayerGame()
    {
        mainMenu.SetActive(false);
        roundsSelector.SetActive(true);
    }
}
