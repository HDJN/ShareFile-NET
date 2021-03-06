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
	public class SimpleQuery : ODataObject 
	{

		/// <summary>
		/// Item type to search for (ex "File", "Folder", etc.)
		/// </summary>
		public string ItemType { get; set; }

		/// <summary>
		/// Parent id constraint on search results
		/// </summary>
		public string ParentID { get; set; }

		/// <summary>
		/// Creator id constraint on search results
		/// </summary>
		public string CreatorID { get; set; }

		/// <summary>
		/// Search term to search for
		/// </summary>
		public string SearchQuery { get; set; }

		/// <summary>
		/// Item creation date range constraint start date in UTC
		/// </summary>
		public string CreateStartDate { get; set; }

		/// <summary>
		/// Item creation date range constraint end date in UTC
		/// </summary>
		public string CreateEndDate { get; set; }

		/// <summary>
		/// Whether item content should be included in the search or not.
		/// </summary>
		public bool ItemNameOnly { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as SimpleQuery;
			if(typedSource != null)
			{
				ItemType = typedSource.ItemType;
				ParentID = typedSource.ParentID;
				CreatorID = typedSource.CreatorID;
				SearchQuery = typedSource.SearchQuery;
				CreateStartDate = typedSource.CreateStartDate;
				CreateEndDate = typedSource.CreateEndDate;
				ItemNameOnly = typedSource.ItemNameOnly;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("ItemType", out token) && token.Type != JTokenType.Null)
				{
					ItemType = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("ParentID", out token) && token.Type != JTokenType.Null)
				{
					ParentID = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("CreatorID", out token) && token.Type != JTokenType.Null)
				{
					CreatorID = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("SearchQuery", out token) && token.Type != JTokenType.Null)
				{
					SearchQuery = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("CreateStartDate", out token) && token.Type != JTokenType.Null)
				{
					CreateStartDate = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("CreateEndDate", out token) && token.Type != JTokenType.Null)
				{
					CreateEndDate = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("ItemNameOnly", out token) && token.Type != JTokenType.Null)
				{
					ItemNameOnly = (bool)serializer.Deserialize(token.CreateReader(), typeof(bool));
				}
			}
		}
	}
}