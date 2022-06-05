namespace Classes
{
	internal class Info
	{
		protected Guid _id;
		protected string _name = "";
		protected string _description = "";
		protected bool unDeleteble = false;

		public Info(string name = " ", string description = " ")
		{
			_id = Guid.NewGuid();
			_name = name;
			_description = description;
		}
		public string GetName() => _name;
		public string GetDescription() => _description;
		public bool GetUndeleteble() => unDeleteble;
		public void SetName(string newName) => _name = newName;
		public void SetDescription(string newDescription) => _description = newDescription;
		public void SetUndeleteble(bool isUnDeleteble) => unDeleteble = isUnDeleteble;
		virtual public Guid GetID() => _id;
	}
}
