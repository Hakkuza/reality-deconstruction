using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// 
/// A tool which can be utilized for construction.
/// 
interface ITool { 

	/// 
	/// Wield the tool.
	/// 
	void Wield();

	///
	/// Put the tool away.
	///
	void Stash();
}


/// 
/// A tool which can be utilized for construction,
/// or deconstruction of any part of type T.
/// 
interface ITool<T> where T : IPart {

	/// 
	/// Utilize the tool to deconstruct the part.
	/// 
	void Construct(T part);

}
