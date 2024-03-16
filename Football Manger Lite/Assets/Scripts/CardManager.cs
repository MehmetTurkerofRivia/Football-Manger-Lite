using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using CI.QuickSave;


public class CardManager : MonoBehaviour
{
    public Transform[] cardPositions;
    public List<PlayerCardData> generatedCards = new List<PlayerCardData>();
    public List<PlayerCardData> PlayerPurchasingPool = new List<PlayerCardData>();
    [SerializeField] private List<PlayerCard> ShowingCard = new List<PlayerCard>();
    [SerializeField] private List<Button> PurchasingButtons = new List<Button>();
    [SerializeField] PlayerCard playerCardPrefab;
    private PlayerCard currentPlayerCard;
    private void Start()
    {
        for (int i = 0; i < 1000; i++)
            GenerateRandomCardData();

        ShowRandomCard();
        for (int i = 0; i < PurchasingButtons.Count; i++)
        {
            PurchasingButtons[i] = ShowingCard[i].button;
        }
    }

    public void GenerateRandomCardData()
    {
        PlayerCardData randomCardData = CreateRandomCard();
        generatedCards.Add(randomCardData);
    }
    private PlayerCardData CreateRandomCard()
    {
        string[] names = {"Ahmet", "Mehmet", "Mustafa", "Ali", "Osman", "İbrahim", "Hüseyin", "Hasan", "İsmail", "Yusuf",
            "Ömer", "Murat", "Süleyman", "Kadir", "Fatih", "İsmet", "Erdem", "Yasin", "Emre", "Yunus",
            "Hakan", "Cem", "Volkan", "Erdogan", "Emir", "Serkan", "Oğuz", "Tolgahan", "Berkay", "İlker",
            "Orhan", "Kaan", "Alper", "Yiğit", "Okan", "Tarık", "Ege", "Uğur", "Kemal", "Batuhan",
            "Mert", "Barış", "Furkan", "Yavuz", "Onur", "Tuna", "Erkan", "Deniz", "Eren", "Can",
            "Kerem", "Emirhan", "Doğan", "Ozan", "Arda", "İlhan", "Ercan", "Cihan", "Erhan", "Bora",
            "Arif", "Görkem", "Ahmetcan", "Mehmetcan", "Umut", "Mehmetali", "Taylan", "Halis", "Onurcan", "Berk",
            "Emircan", "Mahmut", "Gökhan", "Kamil", "Yunus Emre", "Emre Can", "Cengiz", "Güven", "Necati", "Kaan",
            "Berkant", "İsmail Can", "Cihan", "Ali İhsan", "Recep", "Yılmaz", "Sadi", "Bülent", "Nail", "Rıza"};
        PlayerCardData randomCard = ScriptableObject.CreateInstance<PlayerCardData>();
        int rulet = Random.Range(0, names.Length);
        randomCard.playerName = names[rulet];
        randomCard.shoot = Random.Range(1, 8);
        randomCard.dribbling = Random.Range(1, 8);
        randomCard.pas = Random.Range(1, 8);
        randomCard.reflex = Random.Range(1, 8);
        randomCard.aggression = Random.Range(1, 8);
        randomCard.pace = Random.Range(1, 8);
        randomCard.marking = Random.Range(1, 8);
        randomCard.id = Random.Range(0, 10000);
        randomCard.value = 28 * (randomCard.shoot + randomCard.dribbling + randomCard.pas + randomCard.reflex + randomCard.aggression + randomCard.pace + randomCard.marking);
        return randomCard;
    }
    private void ShowRandomCard()
    {
        for (int i = 0; i < cardPositions.Length; i++)
        {
            int randomIndex = Random.Range(0, generatedCards.Count);
            PlayerCardData cardData = generatedCards[randomIndex];
            currentPlayerCard = Instantiate(playerCardPrefab, cardPositions[i]);
            currentPlayerCard.SetPlayer(cardData);
            ShowingCard.Add(currentPlayerCard);
        }
    }
    public void Refresh()
    {
        foreach (PlayerCard card in ShowingCard)
        {
            Destroy(card.gameObject);
        }
        ShowingCard.Clear();
        ShowRandomCard();
    }
    public void Purchasing(int buttonIndex)
    {
        int cardIndex = buttonIndex;
        int cardId = ShowingCard[cardIndex].id;
        PlayerPurchasingPool.Add(generatedCards.FirstOrDefault(card => card.id == cardId));
    }
    var writer = QuickSaveWriter.Create("Player");
    write
}
