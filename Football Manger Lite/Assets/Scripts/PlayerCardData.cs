using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "NewPlayerCard", menuName = "Player Card")]
public class PlayerCardData : ScriptableObject
{
    public Button button;
    public string playerName;
    public int shoot;
    public int dribbling;
    public int pas;
    public int reflex;
    public int aggression;
    public int pace;
    public int marking;
    public int value;
    public int id;
}
