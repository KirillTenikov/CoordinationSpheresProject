using CoordinationSpheresProject.Polyhedrons;
using System.Windows.Media.Media3D;
using System.Windows.Media;

namespace CoordinationSpheresProject.Renderers
{
	public class  CubeWPFRenderer:I3dRenderer
	{
		private MeshGeometry3D _mesh;
		private Cube _cube;
		
		public Cube Cube 
		{
			get	
			{
				return _cube;
			}
			
		 	set
			{
				_cube=value;
				CalcMeshPositions();
			}
		}
		
		public IContext Context{get; set;}	
				
		public CubeWPFRenderer(Cube cube)
		{
			_mesh=new MeshGeometry3D();	
			Cube=cube;
			CalcMeshTriangleIndexes();
		}
		
		public void Render3d()
		{
		
		}
		
		private void CalcMeshPositions()
		{
			_mesh.Positions.Clear();
			for(int z=-1;z<=1;z+=2)
				for(int y=-1;y<=1;y+=2)
					for(int x=-1;x<=1;x+=2)
						_mesh.Positions.Add(new Point3D(
											Cube.Center.X+x*Cube.EdgeLength/2,
												Cube.Center.Y+y*Cube.EdgeLength/2,
													Cube.Center.Z+z*Cube.EdgeLength/2));
					
		}
		private void CalcMeshTriangleIndexes()
		{
			_mesh.TriangleIndices=new Int32Collection(new int[]{
				0,2,1, 1,2,3, 
				0,4,2, 2,4,6,
				0,1,4, 1,5,4,
				1,7,5, 1,3,7,
				4,5,6, 7,6,5,
				2,6,3, 3,6,7});
			
		}
	
	}
}