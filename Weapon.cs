public class Weapon : Item
{
    public int MinimumDamage { get; set; }
    public int MaximumDamage { get; set; }

    public Weapon(int id, string name, string namePlural, int minDamage, int maxDamage)
        : base(id, name, namePlural)
    {
        // voeg alleen de damage toe aan de items
        MinimumDamage = minDamage;
        MaximumDamage = maxDamage;
    }
}
