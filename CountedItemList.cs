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

  public void AddCountedItem(CountedItem newitem) {
    TheCountedItemList.Add(newitem);
  }
}
