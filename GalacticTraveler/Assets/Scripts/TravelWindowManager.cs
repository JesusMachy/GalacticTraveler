using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TravelWindowManager : MonoBehaviour
{
    GameManager gm;

    public Text CurrentLocationText;
    public Transform OptionsMenu;
    public GameObject OptionPrefab;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        Show();
    }

    public void Show()
    {
        foreach (GameObject go in OptionsMenu) Destroy(go);

        CurrentLocationText.text = gm.PlayerLocation.name;
        foreach(Location exit in gm.PlayerLocation.Exits)
        {
            CreateExitOption("[EXIT] " + exit.name, exit);
        }
    }

    void CreateExitOption(string descriptionText, Location exit)
    {
        GameObject go = OptionPrefab;
        go.GetComponentInChildren<Text>().text = descriptionText;
        go.GetComponent<ExitOptionController>().Exit = exit;
        Instantiate(go, OptionsMenu);
    }
}
