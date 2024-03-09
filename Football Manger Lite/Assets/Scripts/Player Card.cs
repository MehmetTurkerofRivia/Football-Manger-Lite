using UnityEngine;
using UnityEngine.UI;

public class PlayerCard : MonoBehaviour
{
    public int id;
    public Text[] cardTexts;
    [SerializeField] public Button button;
    public void SetPlayer(PlayerCardData cardData)
    {
        cardTexts[0].text = cardData.playerName;
        cardTexts[1].text = "Shoot: " + cardData.shoot.ToString();
        cardTexts[2].text = "Dribbling: " + cardData.dribbling.ToString();
        cardTexts[3].text = "Pass: " + cardData.pas.ToString();
        cardTexts[4].text = "Marking: " + cardData.marking.ToString();
        cardTexts[5].text = "Aggression: " + cardData.aggression.ToString();
        cardTexts[6].text = "Pace: " + cardData.pace.ToString();
        cardTexts[7].text = "Reflex: " + cardData.reflex.ToString();            
        cardTexts[8].text = "Price: " + cardData.value.ToString();
        id = cardData.id;

    }
}
