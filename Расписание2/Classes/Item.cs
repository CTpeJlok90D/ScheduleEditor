namespace Classes
{
	internal class Item
		: Info
	{
		private List<Info> requiredClassRoomTypes = new List<Info>();
		public Item(string name, string description)
			: base(name, description) { }
		public List<Info> GetRequiredClassRoomTypes() => requiredClassRoomTypes;
		public void AddRequiredClassRoomTypes(Info newType) => requiredClassRoomTypes.Add(newType);
		public void RemoveRequiredClassRoomTypes(Info deleteType) => requiredClassRoomTypes.Remove(deleteType);
	}
}