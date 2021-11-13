﻿//
//	Copyright 2021 Frederick William Haslam born 1962 in the USA
//

namespace Verbose.Utility {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;

	using static Verbose.Utility.VerboseSupport;

	/// <summary>
	/// String and collection oriented assertions.  
	/// Provides common string and collection relations as assertions.
	/// </summary>
	public class GenericCollectionAsserts {

		//====================
		// generic collections
		//====================
				
		static public void Empty<T>( ICollection<T> actual ) {
			if (actual!=null && actual.Count>0 ) {
				VerboseFail("Collection is not empty");
			}
		}

		static public void NotEmpty<T>( ICollection<T> actual ) {
			if (actual==null) VerboseFail("Collection is null");
			if (actual.Count==0) VerboseFail("Collection is empty");
		}


		// generic collections single value
		//=================================

		static public void First<T>( T expect, ICollection<T> actual ) where T:IComparable<T> {
			//if (expect==null)) VerboseFail("Cannot expect null for First.");
			if (actual==null || actual.Count==0) VerboseFail("Collection is empty, no first element.");
			T check = actual.ToList().First();
			if (expect==null && check==null) return;
			if ( expect.CompareTo( check ) != 0 ) {
				VerboseFail("First element of collection is not a match.");
			}
		}

		static public void Last<T>( T expect, ICollection<T> actual ) where T:IComparable<T> {
			//if (expect==null)) VerboseFail("Cannot expect null for Last.");
			if (actual==null || actual.Count==0) VerboseFail("Collection is empty, no last element.");
			T check = actual.ToList().Last();
			if (expect==null && check==null) return;
			if ( expect.CompareTo( check ) != 0 ) {
				VerboseFail("Last element of collection is not a match.");
			}
		}

		static public void Contains<T>( T expect, ICollection<T> actual ) where T:IComparable<T> {
			//if (expect==null)) VerboseFail("Cannot expect null for Contains.");
			if (actual==null || actual.Count==0) VerboseFail("Collection is empty, no elements.");
			foreach( T check in actual.ToList() ) {
				if ( (expect==null && check==null) || expect.CompareTo( check ) == 0 ) return;	// match found
			}
			VerboseFail("Collection does not contain element.");
		}

		static public void NotContains<T>( T expect, ICollection<T> actual ) where T:IComparable<T> {
			//if (expect==null)) VerboseFail("Cannot expect null for Contains.");
			if (actual==null || actual.Count==0) VerboseFail("Collection is empty, no elements.");
			foreach( T check in actual.ToList() ) {
				if ( (expect==null && check==null) || expect.CompareTo( check ) == 0 )
					VerboseFail("Collection contains element.");
			}
		}
		
		// generic collections multi value collection
		//===========================================

		static public void StartsWith<T>( ICollection<T> expect, ICollection<T> actual ) {
			VerboseFail("write me");
		}

		static public void EndsWith<T>( ICollection<T> expect, ICollection<T> actual ) {
			VerboseFail("write me");
		}
					
		static public void Contains<T>( ICollection<T> expect, ICollection<T> actual ) {
			VerboseFail("write me");
		}

		static public void NotContains<T>(  ICollection<T> expect, ICollection<T> actual ) {
			VerboseFail("write me");
		}


		// generic collections multi value params
		//===========================================

		static public void StartsWith<T>( ICollection<T> actual, params T[] expect ) {
			VerboseFail("write me");
		}

		static public void EndsWith<T>( ICollection<T> actual, params T[] expect ) {
			VerboseFail("write me");
		}
		
		static public void Contains<T>( ICollection<T> actual, params T[] expect ) {
			VerboseFail("write me");
		}

		static public void NotContains<T>( ICollection<T> actual, params T[] expect ) {
			VerboseFail("write me");
		}

	}

}
