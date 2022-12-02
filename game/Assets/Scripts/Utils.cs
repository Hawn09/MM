using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utils : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	static public float RoundToPlaces(float f, int places = 2)
	{
		float mult = Mathf.Pow(10, places);
		f *= mult;
		f = Mathf.Round(f);
		f /= mult;
		return (f);
	}

	static public string AddCommasToNumber(float f, int places = 2)
	{
		int n = Mathf.RoundToInt(f);
		f -= n;
		f = RoundToPlaces(f, places);
		string str = AddCommasToNumber(n);
		str += "." + (f * Mathf.Pow(10, places));
		return (str);
	}
	static public string AddCommasToNumber(int n)
	{
		int rem;
		int div;
		string res = "";
		string rems;
		while (n > 0)
		{
			rem = n % 1000;
			div = n / 1000;
			rems = rem.ToString();

			while (div > 0 && rems.Length < 3)
			{
				rems = "0" + rems;
			}
			// TODO: I think there must be a faster way to concatenate strings. Maybe I could do this with an array or something
			if (res == "")
			{
				res = rems;
			}
			else
			{
				res = rems + "," + res.ToString();
			}
			n = div;
		}
		if (res == "") res = "0";
		return (res);
	}
	
}
