﻿using System;
using Security;
using Foundation;
using Xamarin.Forms;
using XamarinForms.QbChat.iOS;
using QbChat.Pcl.Interfaces;

[assembly: Dependency(typeof(IOSDeviceUid))]
namespace XamarinForms.QbChat.iOS
{
	public class IOSDeviceUid : IDeviceIdentifier
	{
		public string GetIdentifier()
		{
			string serial = string.Empty;
			var rec = new SecRecord(SecKind.GenericPassword)
			{
				Generic = NSData.FromString("uidNumber")
			};

			SecStatusCode res;
			var match = SecKeyChain.QueryAsRecord(rec, out res);
			if (res == SecStatusCode.Success)
			{
				serial = match.ValueData.ToString();
			}
			else
			{
				var uidNumberRecord = new SecRecord(SecKind.GenericPassword)
				{
					Label = "uid",
					ValueData = NSData.FromString(Guid.NewGuid().ToString()),
					Generic = NSData.FromString("uidNumber")
				};

				var err = SecKeyChain.Add(uidNumberRecord);
				serial = uidNumberRecord.ValueData.ToString();
			}

			return serial;

		}
	}
}

