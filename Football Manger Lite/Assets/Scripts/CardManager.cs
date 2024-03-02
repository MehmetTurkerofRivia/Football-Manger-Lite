using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardManager : MonoBehaviour
{
    public GameObject cardPrefab;
    public List<PlayerCardData> generatedCards = new List<PlayerCardData>(); // Oluşturulan kartların listesi
    public List<Transform> cardPositions; // Kartların yerleştirileceği pozisyonların listesi

    // Generate butonuna bağlanacak fonksiyon
    public void GenerateRandomCardData()
    {
        PlayerCardData randomCardData = CreateRandomCard();
        generatedCards.Add(randomCardData);
    }

    // Show butonuna bağlanacak fonksiyon
    public void ShowRandomCard()
    {
        for (int i = 0; i < Mathf.Min(generatedCards.Count, cardPositions.Count); i++)
        {
            GameObject newCard = Instantiate(cardPrefab, cardPositions[i].position, Quaternion.identity);
            PlayerCard playerCard = newCard.GetComponent<PlayerCard>();
            playerCard.SetPlayer(generatedCards[i]);
        }
    }

    // Rastgele bir kart oluştur
    private PlayerCardData CreateRandomCard()
    {
        PlayerCardData randomCard = ScriptableObject.CreateInstance<PlayerCardData>();
        randomCard.playerName = "Mehmet";
        randomCard.shoot = Random.Range(1, 8);
        randomCard.dribbling = Random.Range(1, 8);
        randomCard.pas = Random.Range(1, 8);
        randomCard.reflex = Random.Range(1, 8);
        randomCard.aggression = Random.Range(1, 8);
        randomCard.pace = Random.Range(1, 8);
        randomCard.marking = Random.Range(1, 8);
        return randomCard;
    }
}
