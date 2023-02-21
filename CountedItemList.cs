public class CountedItemList
{
  public List<CountedItem> TheCountedItemList;

  public CountedItemList()
  {

  }

  public void AddItem(Item newitem)
  {
    TheCountedItemList.Add(new CountedItem(newitem, 1));
  }

  public void AddCountedItem(CountedItem newitem)
  {
    TheCountedItemList.Add(newitem);
  }
}