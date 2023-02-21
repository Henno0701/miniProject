public class Location
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public Item ItemRequiredToEnter {get; set; }

    public Quest QuestAvailableHere {get; set; }
    public Monster MonsterLivingHere {get; set; }
    public Location LocationToNorth;
    public Location LocationToEast;
    public Location LocationToWest;
    public Location LocationToSouth;

    public Location(int id, string name, string description, Item itemrequiredtoenter, Quest questavailablehere, Monster monsterlivinghere)
    {
        ID = id;
        Name = name;
        Description = description;
        ItemRequiredToEnter = itemrequiredtoenter;
        QuestAvailableHere = questavailablehere;
        MonsterLivingHere = monsterlivinghere;
    }
}
