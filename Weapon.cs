public class Weapon : Item
{
    public int MinimumDamage { get; set; }
    public int MaximumDamage { get; set; }

    public Weapon(int id, string name, string namePlural, int minDamage, int maxDamage)
        : base(id, name, namePlural)
    {
        MinimumDamage = minDamage;
        MaximumDamage = maxDamage;
    }
}
