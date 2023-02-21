public class CountedItemList
{
  public List<CountedItem> TheCountedItemList;

  public CountedItemList()
  {
    
  }

  public void AddItem(CountedItem newitem)
  {
    TheCountedItemList.Add(newitem);
  }
}
