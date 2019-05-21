using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Metadata.Query;
using System.Collections.Generic;
using System.Linq;

namespace MsCrmTools.SiteMapEditor.AppCode
{
    internal class MetadataHelper
    {
        public static List<EntityMetadata> GetEntitiesNames(IOrganizationService service)
        {
            EntityQueryExpression entityQueryExpression = new EntityQueryExpression()
            {
                // Sans propriétés d'entité
                Properties = new MetadataPropertiesExpression
                {
                    AllProperties = false,
                    PropertyNames = { "DisplayName", "LogicalName", "SchemaName" }
                }
            };

            RetrieveMetadataChangesRequest retrieveMetadataChangesRequest = new RetrieveMetadataChangesRequest
            {
                Query = entityQueryExpression,
                ClientVersionStamp = null
            };

            var response = (RetrieveMetadataChangesResponse)service.Execute(retrieveMetadataChangesRequest);

            return response.EntityMetadata.ToList();
        }
    }
}