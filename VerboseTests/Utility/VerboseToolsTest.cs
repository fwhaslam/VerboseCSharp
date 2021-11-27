﻿//
//	Copyright 2021 Frederick William Haslam born 1962 in the USA
//

namespace Verbose.Utility {

	using Microsoft.VisualStudio.TestTools.UnitTesting;

	using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
	using static Verbose.Utility.VerboseAsserts;

	public class TestMe {
		public string AString {  get; set; }
		public int AnInt {  get; set; }
		public char AChar {  get; set; }
	}

	[TestClass]
	public class VerboseToolsTest {

		[TestMethod]
		public void AsString() {

			// preparation
			TestMe work = new TestMe();
			work.AString = "some-value";
			work.AnInt = 123;
			work.AChar = 'X';

			// invocation
			var result = VerboseTools.AsString( work );

			// assertions
			AreEqual(
				"{\"AChar\":\"X\",\"AnInt\":123,\"AString\":\"some-value\"}", 
				result );
		}

		[TestMethod]
		public void AsString_zeroCharIssue() {

			TestMe work = new TestMe();

			// invocation
			var result = VerboseTools.AsString( work );

			// assertions
			AreEqual(
				"{\"AChar\":\"\\u0000\",\"AnInt\":0,\"AString\":null}", 
				result );		
		}

		[TestMethod]
		public void ToString_object() {

			TestMe work = new TestMe();
			work.AString = "some-value";
			work.AnInt = 123;
			work.AChar = 'X';

			// invocation
			var result = VerboseTools.ToString( work );

			// assertions
			AreEqual(
				"{\"AChar\":\"X\",\"AnInt\":123,\"AString\":\"some-value\"}", 
				result );
		}

		
		[TestMethod]
		public void AsPrettyString() {

			TestMe work = new TestMe();
			work.AString = "some-value";
			work.AnInt = 123;
			work.AChar = 'X';

			// invocation
			var result = VerboseTools.AsPrettyString( work );

			// assertions
			StringsAreEqual("{\n"+
    				"  \"AChar\": \"X\",\n"+
    				"  \"AnInt\": 123,\n"+
    				"  \"AString\": \"some-value\"\n"+
    				"}",  result );
		}
		
		[TestMethod]
		public void ToPrettyString() {

			TestMe work = new TestMe();
			work.AString = "some-value";
			work.AnInt = 123;
			work.AChar = 'X';

			// invocation
			var result = VerboseTools.ToPrettyString( work );

			// assertions
			StringsAreEqual("{\n"+
    				"  \"AChar\": \"X\",\n"+
    				"  \"AnInt\": 123,\n"+
    				"  \"AString\": \"some-value\"\n"+
    				"}",  result );
		}

		[TestMethod]
		public void IsNullEquals_genericx() {

			IsTrue( VerboseTools.IsNullEquals<string>( null, null ) );
			IsTrue( VerboseTools.IsNullEquals<string>( "A", "A" ) );

			IsFalse( VerboseTools.IsNullEquals<string>( null, "A" ) );
			IsFalse( VerboseTools.IsNullEquals<string>( "A", null ) );
		}

	}

}
