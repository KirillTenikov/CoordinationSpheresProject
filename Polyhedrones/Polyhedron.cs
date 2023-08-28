namespace CoordinationSpheresProject.Polyhedrons
{
	public abstract class Polyhedron
	{
		//fields		
		private Matrix3d _matrixTransform;
		private Point3d _vectorShift;
		private double _scaleTransform;
		//properties
		public Point3d Center {get; set;}
		//methods
		public void  Transform(Matrix3d matrix)
		{
			_matrixTransform=matrix;
		}
		public void  Move(Point3d vector)
		{
			_vectorShift=vector;
		}
		public void  Scale(double scale)
		{
			_scaleTransform=scale;
		}
		
	}
}