using UnityEngine;
using UnityEngine.UI;

public class PlayerCard : MonoBehaviour
{
    public Text[] cardTexts;
    public PlayerCardData ShowingCard;

    public void SetPlayer(PlayerCardData cardData)
    {
        ShowingCard = cardData;
        cardTexts[0].text = cardData.playerName;
        cardTexts[1].text = "Shoot: " + cardData.shoot.ToString();
        cardTexts[2].text = "Dribbling: " + cardData.dribbling.ToString();
        cardTexts[3].text = "Pass: " + cardData.pas.ToString();
        cardTexts[4].text = "Reflex: " + cardData.reflex.ToString();
        cardTexts[5].text = "Aggression: " + cardData.aggression.ToString();
        cardTexts[6].text = "Pace: " + cardData.pace.ToString();
        cardTexts[7].text = "Marking: " + cardData.marking.ToString();
        cardTexts[8].text = "Price: " + cardData.value.ToString();
    }
}
