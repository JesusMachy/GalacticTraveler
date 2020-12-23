using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterWindowManager : MonoBehaviour
{
    GameManager gm;

    public Text StrengthText;
    public Text AgilityText;
    public Text PerceptionText;
    public Text ToughnessText;
    public Text InteligenceText;
    public Text CharismaText;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Show();
    }

    public void Show()
    {
        StrengthText.text = gm.Player.GetStrength().ToString();
        AgilityText.text = gm.Player.GetAgility().ToString();
        PerceptionText.text = gm.Player.GetPerception().ToString();
        ToughnessText.text = gm.Player.GetToughness().ToString();
        InteligenceText.text = gm.Player.GetInteligence().ToString();
        CharismaText.text = gm.Player.GetCharisma().ToString();
    }
}
