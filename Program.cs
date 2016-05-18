using System;

namespace DeleteChar
{
	class MainClass
	{
		/* Make function to delete character in string efficiently
		 * string removeChars(string str, string remove);
		 * 
		 * 1. make all element to 'false' in the lookup array
		 * 2. As looking each character in the Remove Array, Set the value of that Character as True in Lookup Array.
		 * 3. Using Start Index and Destination Index to look through Str,
		 *    if the value of the charcater is false, copy it.
         */
		public static string removeChars(string str, string remove)
		{
			char[] s = str.ToCharArray ();  // character lookup array
			char[] r = remove.ToCharArray ();  // remove array

			int source, dest = 0; //index

			//initialize flag -> allocates it with false.
			bool[] flags = new bool[128];

			//set flag be true, each value of remove array
			for (source = 0; source < r.Length; ++source) {
				flags [r[source]] = true;
			}
			//only copy a char which is false to overwrite same index in str[]
			for (source = 0;  source <s.Length; ++source) 
			{
				if(flags[s[source]]== false){
					s[dest++] = s[source];
				}
			}
			return new string (s, 0, dest);  //from 0 to dest in string s
		}

		public static void Main (string[] args)
		{
			Console.WriteLine ("Removing vowels : Battle of the Vowels: Hawaii vs. Grozny");
			string a = "Battle of the Vowels: Hawaii vs. Grozny";
			string b = "aeiou";
			//removeChars(a, b);
			Console.WriteLine (removeChars(a,b));

		}
	}
}
