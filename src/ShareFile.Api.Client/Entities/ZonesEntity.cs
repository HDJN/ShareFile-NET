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
using ShareFile.Api.Models;
using ShareFile.Api.Client;
using ShareFile.Api.Client.Requests;
using ShareFile.Api.Client.Extensions;


namespace ShareFile.Api.Client.Entities
{
    public interface IZonesEntity : IEntityBase
    {
        
        /// <summary>
        /// Get List of Zones
        /// </summary>
        /// <remarks>
        /// Retrieve the list of Zones accessible to the authenticated user
        /// This method will concatenate the list of private zones in the user's account and the
        /// list of public zones accessible to this account. Any user can see the list of zones.
        /// </remarks>
        /// <param name="services"></param>
        /// <param name="includeDisabled"></param>
        /// <returns>
        /// The list of public and private zones accessible to this user
        /// </returns>
        IQuery<ODataFeed<Zone>> Get(ZoneService services = ZoneService.StorageZone, bool includeDisabled = false);
        
        /// <summary>
        /// Get List of Zones
        /// </summary>
        /// <remarks>
        /// Retrieve the list of Zones accessible to the authenticated user
        /// This method will concatenate the list of private zones in the user's account and the
        /// list of public zones accessible to this account. Any user can see the list of zones.
        /// </remarks>
        /// <param name="services"></param>
        /// <param name="includeDisabled"></param>
        /// <returns>
        /// The list of public and private zones accessible to this user
        /// </returns>
        IQuery<Zone> Get(Uri url, bool secret = false);
        
        /// <summary>
        /// Create Zone
        /// </summary>
        /// <example>
        /// {
        /// "Name":"Name",
        /// "HeartbeatTolerance":10,
        /// "ZoneServices":"StorageZone, SharepointConnector, NetworkShareConnector"
        /// }
        /// </example>
        /// <remarks>
        /// Creates a new Zone.
        /// </remarks>
        /// <returns>
        /// the created zone
        /// </returns>
        IQuery<Zone> Create(Zone zone);
        
        /// <summary>
        /// Update Zone
        /// </summary>
        /// <example>
        /// {
        /// "Name":"Name",
        /// "HeartbeatTolerance":10,
        /// "ZoneServices":"StorageZone, SharepointConnector, NetworkShareConnector"
        /// }
        /// </example>
        /// <remarks>
        /// Updates an existing zone
        /// </remarks>
        /// <param name="url"></param>
        /// <param name="zone"></param>
        /// <returns>
        /// The modified zone
        /// </returns>
        IQuery<Zone> Update(Uri url, Zone zone);
        
        /// <summary>
        /// Delete Zone
        /// </summary>
        /// <remarks>
        /// Removes an existing zone
        /// </remarks>
        /// <param name="url"></param>
        /// <param name="force"></param>
        /// <param name="newDefaultZoneId"></param>
        IQuery Delete(Uri url, bool force = false, string newDefaultZoneId = null);
        
        /// <summary>
        /// Reset Zone Secret
        /// </summary>
        /// <remarks>
        /// Resets the current Zone Secret to a new Random value
        /// Caution! This Call will invalidate all Storage Center communications until the Storage Center Zone secret
        /// is also updated.
        /// User must be a Zone admin to perform this action
        /// </remarks>
        /// <param name="url"></param>
        /// <returns>
        /// The modified Zone object
        /// </returns>
        IQuery<Zone> ResetSecret(Uri url);
        
        /// <summary>
        /// Get the tenants of a multi-tenant zone
        /// </summary>
        /// <param name="parentUrl"></param>
        /// <returns>
        /// List of tenant accounts, not including the zone admin account.
        /// </returns>
        IQuery<ODataFeed<Account>> GetTenants(Uri parentUrl);
        
        /// <summary>
        /// Add a tenant account to a multi-tenant zone
        /// </summary>
        /// <param name="parentUrl"></param>
        /// <param name="accountId"></param>
        IQuery<Account> CreateTenants(Uri parentUrl, string accountId);
        
        /// <summary>
        /// Remove a tenant from a multi-tenant zone
        /// </summary>
        /// <param name="parentUrl"></param>
        /// <param name="id"></param>
        /// <param name="newDefaultZoneId"></param>
        /// <param name="expireItems"></param>
        IQuery DeleteTenants(Uri parentUrl, string id, string newDefaultZoneId, bool expireItems = false);
        
        /// <summary>
        /// Get Zone Metadata
        /// </summary>
        /// <remarks>
        /// Gets metadata associated with the specified zone
        /// </remarks>
        /// <param name="url"></param>
        /// <returns>
        /// the zone metadata feed
        /// </returns>
        IQuery<ODataFeed<Metadata>> GetMetadata(Uri url);
        
        /// <summary>
        /// Create or update Zone Metadata
        /// </summary>
        /// <example>
        /// [
        /// {"Name":"metadataName1", "Value":"metadataValue1", "IsPublic":"true"},
        /// {"Name":"metadataName2", "Value":"metadataValue2", "IsPublic":"false"},
        /// ...
        /// ]
        /// </example>
        /// <remarks>
        /// Creates or updates Metadata entries associated with the specified zone
        /// </remarks>
        /// <param name="url"></param>
        /// <param name="metadata"></param>
        /// <returns>
        /// the zone metadata feed
        /// </returns>
        IQuery<ODataFeed<Metadata>> CreateMetadata(Uri url, IEnumerable<Metadata> metadata);
        
        /// <summary>
        /// Delete Zone Metadata
        /// </summary>
        /// <remarks>
        /// Delete the Metadata entry associated with the specified zone
        /// </remarks>
        /// <param name="url"></param>
        /// <param name="name"></param>
        /// <returns>
        /// no data on success
        /// </returns>
        IQuery DeleteMetadata(Uri url, string name);
    }

    public class ZonesEntity : EntityBase, IZonesEntity
    {
        public ZonesEntity (IShareFileClient client)
            : base (client, "Zones")
        { }
        
        
        /// <summary>
        /// Get List of Zones
        /// </summary>
        /// <remarks>
        /// Retrieve the list of Zones accessible to the authenticated user
        /// This method will concatenate the list of private zones in the user's account and the
        /// list of public zones accessible to this account. Any user can see the list of zones.
        /// </remarks>
        /// <param name="services"></param>
        /// <param name="includeDisabled"></param>
        /// <returns>
        /// The list of public and private zones accessible to this user
        /// </returns>
        public IQuery<ODataFeed<Zone>> Get(ZoneService services = ZoneService.StorageZone, bool includeDisabled = false)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<Zone>>(Client);
		    sfApiQuery.From("Zones");
            sfApiQuery.QueryString("services", services);
            sfApiQuery.QueryString("includeDisabled", includeDisabled);
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Get List of Zones
        /// </summary>
        /// <remarks>
        /// Retrieve the list of Zones accessible to the authenticated user
        /// This method will concatenate the list of private zones in the user's account and the
        /// list of public zones accessible to this account. Any user can see the list of zones.
        /// </remarks>
        /// <param name="services"></param>
        /// <param name="includeDisabled"></param>
        /// <returns>
        /// The list of public and private zones accessible to this user
        /// </returns>
        public IQuery<Zone> Get(Uri url, bool secret = false)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Zone>(Client);
            sfApiQuery.Uri(url);
            sfApiQuery.QueryString("secret", secret);
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Create Zone
        /// </summary>
        /// <example>
        /// {
        /// "Name":"Name",
        /// "HeartbeatTolerance":10,
        /// "ZoneServices":"StorageZone, SharepointConnector, NetworkShareConnector"
        /// }
        /// </example>
        /// <remarks>
        /// Creates a new Zone.
        /// </remarks>
        /// <returns>
        /// the created zone
        /// </returns>
        public IQuery<Zone> Create(Zone zone)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Zone>(Client);
		    sfApiQuery.From("Zones");
            sfApiQuery.Body = zone;
            sfApiQuery.HttpMethod = "POST";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Update Zone
        /// </summary>
        /// <example>
        /// {
        /// "Name":"Name",
        /// "HeartbeatTolerance":10,
        /// "ZoneServices":"StorageZone, SharepointConnector, NetworkShareConnector"
        /// }
        /// </example>
        /// <remarks>
        /// Updates an existing zone
        /// </remarks>
        /// <param name="url"></param>
        /// <param name="zone"></param>
        /// <returns>
        /// The modified zone
        /// </returns>
        public IQuery<Zone> Update(Uri url, Zone zone)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Zone>(Client);
            sfApiQuery.Uri(url);
            sfApiQuery.Body = zone;
            sfApiQuery.HttpMethod = "PATCH";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Delete Zone
        /// </summary>
        /// <remarks>
        /// Removes an existing zone
        /// </remarks>
        /// <param name="url"></param>
        /// <param name="force"></param>
        /// <param name="newDefaultZoneId"></param>
        public IQuery Delete(Uri url, bool force = false, string newDefaultZoneId = null)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
            sfApiQuery.Uri(url);
            sfApiQuery.QueryString("force", force);
            sfApiQuery.QueryString("newDefaultZoneId", newDefaultZoneId);
            sfApiQuery.HttpMethod = "DELETE";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Reset Zone Secret
        /// </summary>
        /// <remarks>
        /// Resets the current Zone Secret to a new Random value
        /// Caution! This Call will invalidate all Storage Center communications until the Storage Center Zone secret
        /// is also updated.
        /// User must be a Zone admin to perform this action
        /// </remarks>
        /// <param name="url"></param>
        /// <returns>
        /// The modified Zone object
        /// </returns>
        public IQuery<Zone> ResetSecret(Uri url)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Zone>(Client);
		    sfApiQuery.Action("ResetSecret");
            sfApiQuery.Uri(url);
            sfApiQuery.HttpMethod = "POST";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Get the tenants of a multi-tenant zone
        /// </summary>
        /// <param name="parentUrl"></param>
        /// <returns>
        /// List of tenant accounts, not including the zone admin account.
        /// </returns>
        public IQuery<ODataFeed<Account>> GetTenants(Uri parentUrl)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<Account>>(Client);
		    sfApiQuery.Action("Tenants");
            sfApiQuery.Uri(parentUrl);
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Add a tenant account to a multi-tenant zone
        /// </summary>
        /// <param name="parentUrl"></param>
        /// <param name="accountId"></param>
        public IQuery<Account> CreateTenants(Uri parentUrl, string accountId)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<Account>(Client);
		    sfApiQuery.Action("Tenants");
            sfApiQuery.Uri(parentUrl);
            sfApiQuery.QueryString("accountId", accountId);
            sfApiQuery.HttpMethod = "POST";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Remove a tenant from a multi-tenant zone
        /// </summary>
        /// <param name="parentUrl"></param>
        /// <param name="id"></param>
        /// <param name="newDefaultZoneId"></param>
        /// <param name="expireItems"></param>
        public IQuery DeleteTenants(Uri parentUrl, string id, string newDefaultZoneId, bool expireItems = false)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
		    sfApiQuery.Action("Tenants");
            sfApiQuery.Uri(parentUrl);
            sfApiQuery.ActionIds(id);
            sfApiQuery.QueryString("newDefaultZoneId", newDefaultZoneId);
            sfApiQuery.QueryString("expireItems", expireItems);
            sfApiQuery.HttpMethod = "DELETE";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Get Zone Metadata
        /// </summary>
        /// <remarks>
        /// Gets metadata associated with the specified zone
        /// </remarks>
        /// <param name="url"></param>
        /// <returns>
        /// the zone metadata feed
        /// </returns>
        public IQuery<ODataFeed<Metadata>> GetMetadata(Uri url)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<Metadata>>(Client);
		    sfApiQuery.Action("Metadata");
            sfApiQuery.Uri(url);
            sfApiQuery.HttpMethod = "GET";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Create or update Zone Metadata
        /// </summary>
        /// <example>
        /// [
        /// {"Name":"metadataName1", "Value":"metadataValue1", "IsPublic":"true"},
        /// {"Name":"metadataName2", "Value":"metadataValue2", "IsPublic":"false"},
        /// ...
        /// ]
        /// </example>
        /// <remarks>
        /// Creates or updates Metadata entries associated with the specified zone
        /// </remarks>
        /// <param name="url"></param>
        /// <param name="metadata"></param>
        /// <returns>
        /// the zone metadata feed
        /// </returns>
        public IQuery<ODataFeed<Metadata>> CreateMetadata(Uri url, IEnumerable<Metadata> metadata)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query<ODataFeed<Metadata>>(Client);
		    sfApiQuery.Action("Metadata");
            sfApiQuery.Uri(url);
            sfApiQuery.Body = metadata;
            sfApiQuery.HttpMethod = "POST";	
		    return sfApiQuery;
        }
        
        /// <summary>
        /// Delete Zone Metadata
        /// </summary>
        /// <remarks>
        /// Delete the Metadata entry associated with the specified zone
        /// </remarks>
        /// <param name="url"></param>
        /// <param name="name"></param>
        /// <returns>
        /// no data on success
        /// </returns>
        public IQuery DeleteMetadata(Uri url, string name)
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
		    sfApiQuery.Action("Metadata");
            sfApiQuery.Uri(url);
            sfApiQuery.QueryString("name", name);
            sfApiQuery.HttpMethod = "DELETE";	
		    return sfApiQuery;
        }
    }
}
