﻿//--------------------------------------------------
// Singleton継承元クラス
//--------------------------------------------------
public class Singleton<T> 
	where T : class, new()
{
	protected static T _instance = null;
	public static T Instance
	{
		get
		{
			if (_instance == null)
			{
				_instance = new T();
			}
			return _instance;
		}
	}

	protected Singleton() { }
}
