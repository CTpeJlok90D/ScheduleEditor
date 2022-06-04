namespace Classes
{
	internal class Teacher
		: Info
	{
		private List<Item> items = new List<Item>();
		private bool[] workWeek = new bool[7];
		public Teacher(string name)
			: base(name) { }
		public Teacher(string name, string discription)
			: base(name, discription) { }
		public List<Item> GetItems() => items;
		public void AddItem(Item item) => items.Add(item);
		public void RemoveItem(Item item) => items.Remove(item);
	}
}