public class Monster
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string NamePlural { get; set; }
    public int MaximumDamage { get; set; }
    public int RewardExperience { get; set; }
    public int RewardGold { get; set; }
    public List<CountedItem> Loot { get; set; }
    public int CurrentHitPoints { get; set; }

    public Monster(int id, string name, string namePlural, int maximumDamage,
                   int rewardExperience, int rewardGold, List<CountedItem> loot, int currentHitPoints)
    {
        Id = id;
        Name = name;
        NamePlural = namePlural;
        MaximumDamage = maximumDamage;
        RewardExperience = rewardExperience;
        RewardGold = rewardGold;
        Loot = loot;
        CurrentHitPoints = currentHitPoints;
    }
}
