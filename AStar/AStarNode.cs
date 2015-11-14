
public class AStarNode<T>
	{
	public T t;
	public AStarNode<T> parent;
	public AStarNode (T tt,AStarNode<T> p)
		{
		t = tt;
		parent = p;
		}
	public int Cost(){
		if (parent == null)
			return 0;
		else
			return 1+parent.Cost();
	}
}


