namespace CoordinationSpheresProject.Renderers
{
	public interface IContext
	{
		void AddElement(object element);
		void DeleteElement(int index);
		void TransformElement(int index);
		
	}
}