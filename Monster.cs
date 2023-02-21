public class Monster
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string NamePlural { get; set; }
    public int MaximumDamage { get; set; }
    public int RewardExperience { get; set; }
    public int RewardGold { get; set; }
    public List<CountedItemList> Loot;
    public int MaximiumHitPoints { get; set; }
    public int CurrentHitPoints { get; set; }

    public Monster(int id, string name, string namePlural, int maximumDamage,
                   int rewardExperience, int rewardGold, int maximiumhitpoints, int currentHitPoints)
    {
        ID = id;
        Name = name;
        NamePlural = namePlural;
        MaximumDamage = maximumDamage;
        RewardExperience = rewardExperience;
        RewardGold = rewardGold;
        MaximiumHitPoints = maximiumhitpoints;
        CurrentHitPoints = currentHitPoints;
    }
}
