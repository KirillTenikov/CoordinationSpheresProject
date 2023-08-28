using CoordinationSpheresProject.Polyhedrons;
using System.Windows.Media.Media3D;
using System.Windows.Media;
using System.Windows.Data;
using System;

namespace CoordinationSpheresProject.Converters
{
	static public class CubeToModel
	{
		static public GeometryModel3D Convert(Cube cube, Material material)
		{
			MeshGeometry3D mesh=new MeshGeometry3D();
			CalcMeshPositions(mesh, cube);
			CalcMeshTriangleIndexes(mesh);
			return new GeometryModel3D(mesh, material);
		}
		
		static private void CalcMeshPositions(MeshGeometry3D mesh, Cube cube)
		{
			mesh.Positions.Clear();
			for(int z=-1;z<=1;z+=2)
				for(int y=-1;y<=1;y+=2)
					for(int x=-1;x<=1;x+=2)
						mesh.Positions.Add(new Point3D(
											cube.Center.X+x*cube.EdgeLength/2,
												cube.Center.Y+y*cube.EdgeLength/2,
													cube.Center.Z+z*cube.EdgeLength/2));
					
		}
		static private void CalcMeshTriangleIndexes(MeshGeometry3D mesh)
		{
			mesh.TriangleIndices=new Int32Collection(new int[]{
				0,2,1, 1,2,3, 
				0,4,2, 2,4,6,
				0,1,4, 1,5,4,
				1,7,5, 1,3,7,
				4,5,6, 7,6,5,
				2,6,3, 3,6,7});
			
		}
	}
}