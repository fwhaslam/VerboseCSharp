//
//	Copyright 2021 Frederick William Haslam born 1962 in the USA
//

using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

using System.Collections;
using System.Collections.Generic;

namespace Verbose.Utility {

	[TestClass]
	public class StringAssertsTest {

		[TestMethod]
		public void StartsWith_true() {
			StringAsserts.StartsWith( "check", "check true" );
		}

		[TestMethod]
		[ExpectedException(typeof(VerboseAssertionException))]
		public void StartsWith_false() {
			StringAsserts.StartsWith("check","false check");
		}

		[TestMethod]
		public void EndsWith() {
			StringAsserts.EndsWith( "check", "true check" );
		}
		
		[TestMethod]
		[ExpectedException(typeof(VerboseAssertionException))]
		public void EndsWith_false() {
			StringAsserts.EndsWith("check","check false");
		}

		[TestMethod]
		public void Contains() {
			StringAsserts.Contains( "check", "true check true" );
		}

		[TestMethod]
		[ExpectedException(typeof(VerboseAssertionException))]
		public void Contains_false() {
			StringAsserts.Contains( "check", "false false" );
		}

		[TestMethod]
		public void NotContains() {
			StringAsserts.NotContains( "check", "true true" );
		}

		[TestMethod]
		[ExpectedException(typeof(VerboseAssertionException))]
		public void NotContains_false() {
			StringAsserts.NotContains( "check", "false check false" );
		}
		
		[TestMethod]
		public void Empty() {
			StringAsserts.Empty( (string)null );
			StringAsserts.Empty( "" );
		}

		
		[TestMethod]
		[ExpectedException(typeof(VerboseAssertionException))]
		public void Empty_false() {
			StringAsserts.Empty( "false" );
		}

		[TestMethod]
		public void NotEmpty() {
			StringAsserts.NotEmpty("Hello");
		}

		[TestMethod]
		[ExpectedException(typeof(VerboseAssertionException))]
		public void NotEmpty_false_forNull() {
			StringAsserts.NotEmpty((string)null);
		}

		[TestMethod]
		[ExpectedException(typeof(VerboseAssertionException))]
		public void NotEmpty_false_forBlank() {
			StringAsserts.NotEmpty("");
		}

	}
}
