namespace Classes
{
	internal class ClassRoom
		: Info
	{
		public static readonly List<Info> storage = new List<Info>();
		private Info _type;

		public ClassRoom(string name, Info type)
			: base(name)
		{
			storage.Add(this);
			_type = type;
		}
		~ClassRoom() 
		{
			storage.Remove(this);
		}
		public Info GetCabinetType() => _type;
		public void SetCabinetType(Info newType) => _type = newType;
	}
}
