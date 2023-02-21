public class Quest
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int RewardExperiencePoints { get; set; }
    public int RewardGold { get; set; }
    public Item RewardItem { get; set; }
    public Weapon RewardWeapon { get; set; }
    public CountedItemList QuestCompletionItems;

    public Quest(int id, string name, string description, int rewardExperiencePoints, int rewardGold, Item rewarditem, Weapon rewardweapon)
    {
        ID = id;
        Name = name;
        Description = description;
        RewardExperiencePoints = rewardExperiencePoints;
        RewardGold = rewardGold;
        RewardItem = rewarditem;
        RewardWeapon = rewardweapon;
        QuestCompletionItems = new CountedItemList();
    }
}
