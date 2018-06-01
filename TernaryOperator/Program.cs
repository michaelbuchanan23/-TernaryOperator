using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOperator {
	class Program {
		static void Main(string[] args) {

			//note that CODE SECTION 1 below can be rewritten as CODE SECTION 2 below

			//CODE SECTION 1 BEGIN
			int n = 3;
			string s;

			if (n % 2 == 0) {
				s = "even";
			} else {
				s = "odd";
			//CODE SECTION 1 END

			//CODE SECTION 2 BEGIN
			int n = 3;
			string s;

			s = (n % 2 == 0) ? "even" : "odd"; //this is useful (for example) to check if a value was updated correctly
			  //CODE SECTION 2 END

			}
		}
}
