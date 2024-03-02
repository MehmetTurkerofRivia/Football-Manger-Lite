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

    public void SetPlayer(PlayerCardData player)
    {
        playerNameText.text = player.playerName;
        shootText.text = "Shoot: " + player.shoot.ToString();
        dribblingText.text = "Dribbling: " + player.dribbling.ToString();
        pasText.text = "Pass: " + player.pas.ToString();
        reflexText.text = "Reflex: " + player.reflex.ToString();
        aggressionText.text = "Aggression: " + player.aggression.ToString();
        paceText.text = "Pace: " + player.pace.ToString();
        markingText.text = "Marking: " + player.marking.ToString();
    }
}
