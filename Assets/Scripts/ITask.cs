using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// 
/// A task to be assigned to a worker.
/// 
interface ITask {

	/// 
	/// A spot to undertake the task from.
	/// 
	ISpot spot {get;set;}

	/// 
	/// The part to be deconstructed for the task.
	/// 
	IPart part {get;set;}
	
	/// 
	/// The tool to be used to deconstruct the part.
	/// 
	ITool tool {get;set;}

}
