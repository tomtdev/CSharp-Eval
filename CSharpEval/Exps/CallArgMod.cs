﻿/*
	CSharp Eval, a library for arbitrary execution of C# code
	Copyright 2012 Kevin A. Cherry and Timothy W. Wright

	Licensed under the Apache License, Version 2.0 (the "License");
	you may not use this file except in compliance with the License.
	You may obtain a copy of the License at

		http://www.apache.org/licenses/LICENSE-2.0

	Unless required by applicable law or agreed to in writing, software
	distributed under the License is distributed on an "AS IS" BASIS,
	WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
	See the License for the specific language governing permissions and
	limitations under the License.
*/

namespace CSE.Exps {
	///
	/// <summary>
	///		Represents a method call argument modifier
	///		(i.e. ref, out, or none)
	/// </summary>
	/// 
	internal enum CallArgMod {
		///
		/// <summary>
		///		No modifier used (passed by value)
		/// </summary>
		/// 
		VAL,

		///
		/// <summary>
		///		Out keyword used
		/// </summary>
		/// 
		OUT,

		///
		/// <summary>
		///		Ref keyword used
		/// </summary>
		/// 
		REF
	}
}
