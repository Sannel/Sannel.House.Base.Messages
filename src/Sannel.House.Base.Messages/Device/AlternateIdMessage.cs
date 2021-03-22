/* Copyright 2020-2021 Sannel Software, L.L.C.
   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at
      http://www.apache.org/licenses/LICENSE-2.0
   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Sannel.House.Base.Messages.Device
{	
	/// <summary>
	/// The Alternate Id Message
	/// </summary>
	/// <remarks>
	/// This message should never be sent by its self its should always 
	/// be sent as part of devices
	/// </remarks>
	public class AlternateIdMessage
	{
		/// <summary>
		/// The Id of the AlternateId
		/// </summary>
		public int AlternateId { get; set; }
		/// <summary>
		/// The DateTimeOffset the AlternateId Was Created
		/// </summary>
		public DateTimeOffset DateCreated { get; set; }
		/// <summary>
		/// The Uuid of the AlternateId if any
		/// </summary>
		public Guid? Uuid { get; set; }
		/// <summary>
		/// The MacAddress of the AlternateId if any
		/// </summary>
		public long? MacAddress { get; set; }
		/// <summary>
		/// The Manufacture of the AlternateId if any
		/// </summary>
		public string Manufacture { get; set; }
		/// <summary>
		/// The ManufactureId of the AlternateId if any
		/// </summary>
		public string ManufactureId { get; set; }

	}
}
