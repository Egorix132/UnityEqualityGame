using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnitySingleton;

public class RoundsSelectorMenu : SingletonMonoBehaviour<RoundsSelectorMenu>
{
    [SerializeField] private TMP_Dropdown roundsSelectorDropdown;

    private List<int> roundCountOptions = new List<int> { 10, 20, 30, 40, 50 };
    public int RoundsCount { get; private set; } = 20;

    // Start is called before the first frame update
    void Start()
    {
        roundsSelectorDropdown.ClearOptions();
        roundsSelectorDropdown.AddOptions(roundCountOptions.Select(o => 
            new TMP_Dropdown.OptionData(o.ToString())).ToList());

        RoundsCount = roundCountOptions[0];
    }

    void OnChangeRoundsCount(int selectedIndex)
    {
        RoundsCount = roundCountOptions[selectedIndex];
    }
}
