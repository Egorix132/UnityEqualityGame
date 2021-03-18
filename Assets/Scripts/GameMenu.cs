using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnitySingleton;

public class GameMenu : SingletonMonoBehaviour<GameMenu>
{
    [SerializeField] private TMP_Dropdown roundsSelectorDropdown;

    private List<int> roundCountOptions = new List<int> { 10, 20, 30, 40, 50 };
    private int roundsCount = 20;
    // Start is called before the first frame update
    void Start()
    {
        roundsSelectorDropdown.ClearOptions();
        roundsSelectorDropdown.AddOptions(roundCountOptions.Select(o => 
            new TMP_Dropdown.OptionData(o.ToString())).ToList());

        roundsCount = roundCountOptions[0];
    }

    void OnChangeRoundsCount(int selectedIndex)
    {
        roundsCount = roundCountOptions[selectedIndex];
    }
}
