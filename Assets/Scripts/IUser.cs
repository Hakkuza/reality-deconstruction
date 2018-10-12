using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// 
/// A worker who executes tasks and uses tools to deconstruct parts.
/// 
interface IUser {

	///
	/// Current location of the worker.
	///
	ISpot spot {get;set;}

	///
	/// Tool being utilized by the worker.
	///
	ITool tool {get;set;}

	///
	/// Task being executed by the worker.
	///
	ITask task {get;set;}

	///
	/// Assign the worker to the given task.
	///
	void Assign(ITask task);

	///
	/// Direct the worker to walk to to the given spot.
	///
	void WalkTo(ISpot spot);

	///
	/// Have the worker equip the given tool.
	///
	void Equip(ITool tool);

	///
	/// Use the tool to deconstruct the given part.
	///
	void Build(ITool tool, IPart part);

}