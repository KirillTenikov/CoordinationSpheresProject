using CoordinationSpheresProject.Polyhedrons;

namespace CoordinationSpheresProject.ViewModels
{
	public class MainViewModel
	{
		public string Test {get;set;}
		public Cube Cube {get;set;}
		
		public MainViewModel()
		{
			Test="Hello world";
			Cube=new Cube(){
				EdgeLength=1,
				Center=new Point3d(){
					X=0,Y=0,Z=0}		
			};
			
			
		}
	}
}