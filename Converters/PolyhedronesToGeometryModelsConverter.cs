using CoordinationSpheresProject.Polyhedrons;
using System.Windows.Media.Media3D;
using System.Windows.Media;
using System.Windows.Data;
using System;
using System.Collections.Generic;

namespace CoordinationSpheresProject.Converters
{
	public class PolyhedronesToGeometryModelsConverter:IValueConverter 
	{
		public Material Material{get;set;}
		
		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			List<Polyhedron> polyhedrones=(List<Polyhedron>)value;
			Model3DCollection collection=new Model3DCollection();
			GeometryModel3D model;
			foreach(Polyhedron polyhedron in polyhedrones)
			{				
				if(polyhedron is Cube)
				{
					model=CubeToModel.Convert((Cube)polyhedron, Material);
					collection.Add(model);		
				}			
			}
			return collection;
			
		}
		
		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			throw new NotImplementedException();  		
		}
				
	}
}