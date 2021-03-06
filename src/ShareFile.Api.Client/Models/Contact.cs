// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//	   Copyright (c) 2016 Citrix ShareFile. All rights reserved.
// </auto-generated>
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Net;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShareFile.Api.Client.Extensions;
using ShareFile.Api.Client.Exceptions;

namespace ShareFile.Api.Models 
{
#if !ShareFile
	public class Contact : Principal 
	{

		public User User { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Company { get; set; }

		public string EmailMedium { get; set; }

		public string EmailShort { get; set; }

		public bool? IsConfirmed { get; set; }

		public int? Count { get; set; }

		public DateTime? CreatedDate { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as Contact;
			if(typedSource != null)
			{
				User = typedSource.User;
				FirstName = typedSource.FirstName;
				LastName = typedSource.LastName;
				Company = typedSource.Company;
				EmailMedium = typedSource.EmailMedium;
				EmailShort = typedSource.EmailShort;
				IsConfirmed = typedSource.IsConfirmed;
				Count = typedSource.Count;
				CreatedDate = typedSource.CreatedDate;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("User", out token) && token.Type != JTokenType.Null)
				{
					User = (User)serializer.Deserialize(token.CreateReader(), typeof(User));
				}
				if(source.TryGetProperty("FirstName", out token) && token.Type != JTokenType.Null)
				{
					FirstName = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("LastName", out token) && token.Type != JTokenType.Null)
				{
					LastName = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("Company", out token) && token.Type != JTokenType.Null)
				{
					Company = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("EmailMedium", out token) && token.Type != JTokenType.Null)
				{
					EmailMedium = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("EmailShort", out token) && token.Type != JTokenType.Null)
				{
					EmailShort = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("IsConfirmed", out token) && token.Type != JTokenType.Null)
				{
					IsConfirmed = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("Count", out token) && token.Type != JTokenType.Null)
				{
					Count = (int?)serializer.Deserialize(token.CreateReader(), typeof(int?));
				}
				if(source.TryGetProperty("CreatedDate", out token) && token.Type != JTokenType.Null)
				{
					CreatedDate = (DateTime?)serializer.Deserialize(token.CreateReader(), typeof(DateTime?));
				}
			}
		}
	}
#endif
}