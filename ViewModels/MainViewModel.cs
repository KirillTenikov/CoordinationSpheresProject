using CoordinationSpheresProject.Polyhedrons;
using System.Collections.Generic;

namespace CoordinationSpheresProject.ViewModels
{
	public class MainViewModel
	{
		public string Test {get;set;}
		public List<Polyhedron> Polyhedrones {get;set;}
		
		public MainViewModel()
		{
			Polyhedrones=new List<Polyhedron>();
			Test="Hello world";
			Cube cube=new Cube(){
				EdgeLength=1,
				Center=new Point3d(){
					X=0,Y=0,Z=0}		
			};
			Polyhedrones.Add(cube);
			
			
		}
	}
}