using UnityEngine;
using UnityEngine.UI;

public class PlayerCard : MonoBehaviour
{
    public Text playerNameText;
    public Text shootText;
    public Text dribblingText;
    public Text pasText;
    public Text reflexText;
    public Text aggressionText;
    public Text paceText;
    public Text markingText;
    public Text ValueText;


    public PlayerCardData ShowingCard;

    public string playerName;
    public int Value;
    public int shoot;
    public int dribbling;
    public int pas;
    public int reflex;
    public int aggression;
    public int pace;
    public int marking;
    public void SetPlayer()
    {
        playerNameText.text = ShowingCard.playerName;
        shootText.text = "Shoot: " + ShowingCard.shoot.ToString();
        dribblingText.text = "Dribbling: " + ShowingCard.dribbling.ToString();
        pasText.text = "Pass: " + ShowingCard.pas.ToString();
        reflexText.text = "Reflex: " + ShowingCard.reflex.ToString();
        aggressionText.text = "Aggression: " + ShowingCard.aggression.ToString();
        paceText.text = "Pace: " + ShowingCard.pace.ToString();
        markingText.text = "Marking: " + ShowingCard.marking.ToString();           
        ValueText.text = "Price: " + ShowingCard.value.ToString();
    }
}
