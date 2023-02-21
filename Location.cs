namespace MiniProject;
public class Location
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public int ItemName {get; set; }

    public int QuestId {get; set; }
    public int MonsterId {get; set; }

    public Location(int id, string name, string description, int itemname, int questid, int monsterid)
    {
        ID = id;
        Name = name;
        Description = description;
        ItemName = itemname;
        QuestId = questid;
        MonsterId = monsterid;
    }
}
