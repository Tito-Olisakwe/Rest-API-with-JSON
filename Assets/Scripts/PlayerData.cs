[System.Serializable]
public class Position
{
    public float x;
    public float y;
    public float z;
}

[System.Serializable]
public class InventoryItem
{
    public string itemName;
    public int quantity;
    public float weight;
}

[System.Serializable]
public class Record
{
    public string playerName;
    public int level;
    public float health;
    public Position position;
    public InventoryItem[] inventory;
}

[System.Serializable]
public class Metadata
{
    public string id;
    public bool @private;
    public string createdAt;
    public string name;
}

[System.Serializable]
public class PlayerData
{
    public Record record;
    public Metadata metadata;
}
