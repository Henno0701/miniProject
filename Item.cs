public class Item
{
  public int ID { get; set; }
  public string Name { get; set; }
  public string NamePlural { get; set; }

  public Item(int id, string name, string namePlural)
  {
    ID = id;
    Name = name;
    NamePlural = namePlural;
  }
}
