
using System.Collections.Generic;

public interface IAStar<T>
{
	List<T> GetVoisin();
	int Distance(T t);
	int Cost();
}

