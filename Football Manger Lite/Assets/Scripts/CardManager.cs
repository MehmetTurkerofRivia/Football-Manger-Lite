using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public Transform[] cardPositions;
    public List<PlayerCardData> generatedCards = new List<PlayerCardData>();
    public PlayerCard playerCardPrefab;
    private PlayerCard currentPlayerCard;
    private int rulet;
    int a = 0;

    private void Start()
    {
        for (int i = 0; i < 10000; i++)
            GenerateRandomCardData();
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
        rulet = Random.Range(0,names.Length);
        randomCard.playerName = names[rulet];
        randomCard.shoot = Random.Range(1, 8);
        randomCard.dribbling = Random.Range(1, 8);
        randomCard.pas = Random.Range(1, 8);
        randomCard.reflex = Random.Range(1, 8);
        randomCard.aggression = Random.Range(1, 8);
        randomCard.pace = Random.Range(1, 8);
        randomCard.marking = Random.Range(1, 8);
        randomCard.value =28 * (randomCard.shoot + randomCard.dribbling + randomCard.pas + randomCard.reflex + randomCard.aggression + randomCard.pace + randomCard.marking);
        return randomCard;
    }
    private void ShowRandomCard()
    {
        if (generatedCards.Count == 0)
        {
            Debug.LogWarning("There are no cards to show.");
            return;
        }

        int randomIndex = Random.Range(0, generatedCards.Count);
        ShowCard(generatedCards[randomIndex]);
    }

    public void ShowCard(PlayerCardData cardData)
    {
        if (currentPlayerCard != null)
            Destroy(currentPlayerCard.gameObject);



        //foreach (Transform transform in cardPositions)
        //{
        //    currentPlayerCard = Instantiate(playerCardPrefab, cardPositions[a]) ; // Her transform noktasında bir kart instantiate et
        //    currentPlayerCard.ShowingCard = cardData;
        //    currentPlayerCard.SetPlayer();
        //    a++;
        //}

       for(int i = 0; i < generatedCards.Count; i++)
        {
            currentPlayerCard = Instantiate(playerCardPrefab, cardPositions[i]); // Her transform noktasında bir kart instantiate et
            currentPlayerCard.ShowingCard = cardData;
            currentPlayerCard.SetPlayer();
        }      
    }

    public void Refresh()
    {
        ShowRandomCard();
        a = 0;

    }
}
