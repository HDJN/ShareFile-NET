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
	public class GenericConfig : ODataObject 
	{

		public User User { get; set; }

		public string ConfigName { get; set; }

		public int? ConfigSize { get; set; }

		public DateTime? CreationDate { get; set; }

		public DateTime? ModifiedDate { get; set; }

		public string Config { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as GenericConfig;
			if(typedSource != null)
			{
				User = typedSource.User;
				ConfigName = typedSource.ConfigName;
				ConfigSize = typedSource.ConfigSize;
				CreationDate = typedSource.CreationDate;
				ModifiedDate = typedSource.ModifiedDate;
				Config = typedSource.Config;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("User", out token) && token.Type != JTokenType.Null)
				{
					User = (User)serializer.Deserialize(token.CreateReader(), typeof(User));
				}
				if(source.TryGetProperty("ConfigName", out token) && token.Type != JTokenType.Null)
				{
					ConfigName = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("ConfigSize", out token) && token.Type != JTokenType.Null)
				{
					ConfigSize = (int?)serializer.Deserialize(token.CreateReader(), typeof(int?));
				}
				if(source.TryGetProperty("CreationDate", out token) && token.Type != JTokenType.Null)
				{
					CreationDate = (DateTime?)serializer.Deserialize(token.CreateReader(), typeof(DateTime?));
				}
				if(source.TryGetProperty("ModifiedDate", out token) && token.Type != JTokenType.Null)
				{
					ModifiedDate = (DateTime?)serializer.Deserialize(token.CreateReader(), typeof(DateTime?));
				}
				if(source.TryGetProperty("Config", out token) && token.Type != JTokenType.Null)
				{
					Config = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
			}
		}
	}
}