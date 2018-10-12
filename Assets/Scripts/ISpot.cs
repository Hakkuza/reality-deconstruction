using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///
/// A spot for a worker to work from.
///
interface ISpot {

	/// 
	/// Is the spot occupied?
	/// 
	bool isOccupied {get;set;}

	///
	/// The precise location, position and rotation.
	///
	Transform location {get;set;}
}
