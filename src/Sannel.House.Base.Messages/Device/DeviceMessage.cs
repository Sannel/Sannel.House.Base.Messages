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
	/// The Device Information
	/// </summary>
	/// <remarks>
	/// This message should only be sent by the devices project
	/// It will be sent when a new device is added
	/// alternate ids are added or removed
	/// An update to a device has happend
	/// Or on a cron schedule to syncronise devices accross the systems
	/// </remarks>
	public class DeviceMessage
	{
		/// <summary>
		/// The Id of the Device
		/// </summary>
		public int DeviceId { get; set; }

		/// <summary>
		/// The Date The Device was created
		/// </summary>
		public DateTimeOffset DateCreated { get; set; }

		/// <summary>
		/// The Device has been verified to official by a human
		/// </summary>
		public bool Verified { get; set; }

		/// <summary>
		/// The Alternate Ids of this device
		/// </summary>
		public IList<AlternateIdMessage> AlternateIds { get; set; }

	}
}
