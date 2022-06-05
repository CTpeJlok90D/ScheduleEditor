using Classes;
namespace Расписание2
{
	internal static class Program
	{
		[STAThread]
		static void Main()
		{
			Info _anyType = new Info("Любой");
			new ClassRoom("Литература", _anyType);
			new ClassRoom("Русский язык", _anyType);
			new ClassRoom("Математика", _anyType);

			ApplicationConfiguration.Initialize();
			Application.Run(new Forms.RootForm());
		}
	}
}