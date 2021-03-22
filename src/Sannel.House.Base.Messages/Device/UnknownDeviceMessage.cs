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

namespace Sannel.House.Base.Messages.Device
{
	/// <summary>
	/// A Message that represents a new device to a service that is unknown
	/// </summary>
	/// <remarks>
	/// This message is expected to be received by the devices project 
	/// Devices may not send back a message right away
	/// Projects should listen for a <seealso cref="DeviceMessage"/> sent by Devices 
	/// to recieve the official device information
	/// </remarks>
	public class UnknownDeviceMessage
	{
		/// <summary>
		/// Gets or sets the UUID for the alternate id.
		/// </summary>
		/// <value>
		/// The UUID.
		/// </value>
		public Guid? Uuid { get; set; }

		/// <summary>
		/// Gets or sets the mac address.
		/// </summary>
		/// <value>
		/// The mac address.
		/// </value>
		public long? MacAddress { get; set; }

		/// <summary>
		/// Gets or sets the manufacture.
		/// </summary>
		/// <value>
		/// The manufacture.
		/// </value>
		public string Manufacture { get; set; }
		/// <summary>
		/// Gets or sets the manufacture identifier.
		/// </summary>
		/// <value>
		/// The manufacture identifier.
		/// </value>
		public string ManufactureId { get; set; }

	}
}
