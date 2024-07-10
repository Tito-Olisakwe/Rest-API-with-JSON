using UnityEngine;
using TMPro;

public class DisplayPlayerData : MonoBehaviour
{
    public static DisplayPlayerData Instance;

    public TMP_Text playerNameText;
    public TMP_Text levelText;
    public TMP_Text healthText;
    public TMP_Text positionText;
    public TMP_Text inventoryText;

    private void Awake()
    {
        Instance = this;
    }

    public void DisplayData(PlayerData data)
    {
        playerNameText.text = "Player Name: " + data.record.playerName;
        levelText.text = "Level: " + data.record.level;
        healthText.text = "Health: " + data.record.health;
        positionText.text = "Position: (" + data.record.position.x + ", " + data.record.position.y + ", " + data.record.position.z + ")";

        inventoryText.text = "Inventory:\n";
        foreach (var item in data.record.inventory)
        {
            inventoryText.text += item.itemName + " (Qty: " + item.quantity + ", Weight: " + item.weight + ")\n";
        }
    }
}
