﻿// Copyright (c) 2023 Frederick William Haslam born 1962 in the USA.
// Licensed under "The MIT License" https://opensource.org/license/mit/

using Microsoft.VisualStudio.TestTools.UnitTesting;

using VerboseCSharp.Asserts;
using VerboseCSharp.Utility;

using VerboseCSharpTests.TestingFramework;

namespace VerboseCSharpTest.Utility {

	[TestClass]
	public class StringDiffTest {

		[TestMethod]
		public void _constructor() {

			// invocation
			var result = new StringDiff();

			/// assertion
			VerboseAsserts.StringsAreEqual( 
				"{\n"+
				"  \"Actual\": null,\n"+
				"  \"ADisplay\": null,\n"+
				"  \"Cut\": 0,\n"+
				"  \"Diff\": 0,\n"+
				"  \"EDisplay\": null,\n"+
				"  \"Expect\": null,\n"+
				"  \"Explain\": null,\n"+
				"  \"Pointer\": null,\n"+
				"  \"Row\": 0\n"+
				"}", JsonParser.ToJsonString( result ) );
		}
	}
}
