using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.CosmosDB.v2022_11_15.CosmosDB;

internal class Definition : ResourceDefinition
{
    public string Name => "CosmosDB";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CassandraResourcesCreateUpdateCassandraKeyspaceOperation(),
        new CassandraResourcesCreateUpdateCassandraTableOperation(),
        new CassandraResourcesDeleteCassandraKeyspaceOperation(),
        new CassandraResourcesDeleteCassandraTableOperation(),
        new CassandraResourcesGetCassandraKeyspaceOperation(),
        new CassandraResourcesGetCassandraKeyspaceThroughputOperation(),
        new CassandraResourcesGetCassandraTableOperation(),
        new CassandraResourcesGetCassandraTableThroughputOperation(),
        new CassandraResourcesListCassandraKeyspacesOperation(),
        new CassandraResourcesListCassandraTablesOperation(),
        new CassandraResourcesMigrateCassandraKeyspaceToAutoscaleOperation(),
        new CassandraResourcesMigrateCassandraKeyspaceToManualThroughputOperation(),
        new CassandraResourcesMigrateCassandraTableToAutoscaleOperation(),
        new CassandraResourcesMigrateCassandraTableToManualThroughputOperation(),
        new CassandraResourcesUpdateCassandraKeyspaceThroughputOperation(),
        new CassandraResourcesUpdateCassandraTableThroughputOperation(),
        new CollectionListMetricDefinitionsOperation(),
        new CollectionListMetricsOperation(),
        new CollectionListUsagesOperation(),
        new CollectionPartitionListMetricsOperation(),
        new CollectionPartitionListUsagesOperation(),
        new CollectionPartitionRegionListMetricsOperation(),
        new CollectionRegionListMetricsOperation(),
        new DatabaseAccountRegionListMetricsOperation(),
        new DatabaseAccountsCheckNameExistsOperation(),
        new DatabaseAccountsCreateOrUpdateOperation(),
        new DatabaseAccountsDeleteOperation(),
        new DatabaseAccountsFailoverPriorityChangeOperation(),
        new DatabaseAccountsGetOperation(),
        new DatabaseAccountsGetReadOnlyKeysOperation(),
        new DatabaseAccountsListOperation(),
        new DatabaseAccountsListByResourceGroupOperation(),
        new DatabaseAccountsListConnectionStringsOperation(),
        new DatabaseAccountsListKeysOperation(),
        new DatabaseAccountsListMetricDefinitionsOperation(),
        new DatabaseAccountsListMetricsOperation(),
        new DatabaseAccountsListReadOnlyKeysOperation(),
        new DatabaseAccountsListUsagesOperation(),
        new DatabaseAccountsOfflineRegionOperation(),
        new DatabaseAccountsOnlineRegionOperation(),
        new DatabaseAccountsRegenerateKeyOperation(),
        new DatabaseAccountsUpdateOperation(),
        new DatabaseListMetricDefinitionsOperation(),
        new DatabaseListMetricsOperation(),
        new DatabaseListUsagesOperation(),
        new GremlinResourcesCreateUpdateGremlinDatabaseOperation(),
        new GremlinResourcesCreateUpdateGremlinGraphOperation(),
        new GremlinResourcesDeleteGremlinDatabaseOperation(),
        new GremlinResourcesDeleteGremlinGraphOperation(),
        new GremlinResourcesGetGremlinDatabaseOperation(),
        new GremlinResourcesGetGremlinDatabaseThroughputOperation(),
        new GremlinResourcesGetGremlinGraphOperation(),
        new GremlinResourcesGetGremlinGraphThroughputOperation(),
        new GremlinResourcesListGremlinDatabasesOperation(),
        new GremlinResourcesListGremlinGraphsOperation(),
        new GremlinResourcesMigrateGremlinDatabaseToAutoscaleOperation(),
        new GremlinResourcesMigrateGremlinDatabaseToManualThroughputOperation(),
        new GremlinResourcesMigrateGremlinGraphToAutoscaleOperation(),
        new GremlinResourcesMigrateGremlinGraphToManualThroughputOperation(),
        new GremlinResourcesUpdateGremlinDatabaseThroughputOperation(),
        new GremlinResourcesUpdateGremlinGraphThroughputOperation(),
        new LocationsGetOperation(),
        new LocationsListOperation(),
        new MongoDBResourcesCreateUpdateMongoDBCollectionOperation(),
        new MongoDBResourcesCreateUpdateMongoDBDatabaseOperation(),
        new MongoDBResourcesDeleteMongoDBCollectionOperation(),
        new MongoDBResourcesDeleteMongoDBDatabaseOperation(),
        new MongoDBResourcesGetMongoDBCollectionOperation(),
        new MongoDBResourcesGetMongoDBCollectionThroughputOperation(),
        new MongoDBResourcesGetMongoDBDatabaseOperation(),
        new MongoDBResourcesGetMongoDBDatabaseThroughputOperation(),
        new MongoDBResourcesListMongoDBCollectionsOperation(),
        new MongoDBResourcesListMongoDBDatabasesOperation(),
        new MongoDBResourcesMigrateMongoDBCollectionToAutoscaleOperation(),
        new MongoDBResourcesMigrateMongoDBCollectionToManualThroughputOperation(),
        new MongoDBResourcesMigrateMongoDBDatabaseToAutoscaleOperation(),
        new MongoDBResourcesMigrateMongoDBDatabaseToManualThroughputOperation(),
        new MongoDBResourcesUpdateMongoDBCollectionThroughputOperation(),
        new MongoDBResourcesUpdateMongoDBDatabaseThroughputOperation(),
        new PartitionKeyRangeIdListMetricsOperation(),
        new PartitionKeyRangeIdRegionListMetricsOperation(),
        new PercentileListMetricsOperation(),
        new PercentileSourceTargetListMetricsOperation(),
        new PercentileTargetListMetricsOperation(),
        new SqlResourcesCreateUpdateClientEncryptionKeyOperation(),
        new SqlResourcesCreateUpdateSqlContainerOperation(),
        new SqlResourcesCreateUpdateSqlDatabaseOperation(),
        new SqlResourcesCreateUpdateSqlStoredProcedureOperation(),
        new SqlResourcesCreateUpdateSqlTriggerOperation(),
        new SqlResourcesCreateUpdateSqlUserDefinedFunctionOperation(),
        new SqlResourcesDeleteSqlContainerOperation(),
        new SqlResourcesDeleteSqlDatabaseOperation(),
        new SqlResourcesDeleteSqlStoredProcedureOperation(),
        new SqlResourcesDeleteSqlTriggerOperation(),
        new SqlResourcesDeleteSqlUserDefinedFunctionOperation(),
        new SqlResourcesGetClientEncryptionKeyOperation(),
        new SqlResourcesGetSqlContainerOperation(),
        new SqlResourcesGetSqlContainerThroughputOperation(),
        new SqlResourcesGetSqlDatabaseOperation(),
        new SqlResourcesGetSqlDatabaseThroughputOperation(),
        new SqlResourcesGetSqlStoredProcedureOperation(),
        new SqlResourcesGetSqlTriggerOperation(),
        new SqlResourcesGetSqlUserDefinedFunctionOperation(),
        new SqlResourcesListClientEncryptionKeysOperation(),
        new SqlResourcesListSqlContainersOperation(),
        new SqlResourcesListSqlDatabasesOperation(),
        new SqlResourcesListSqlStoredProceduresOperation(),
        new SqlResourcesListSqlTriggersOperation(),
        new SqlResourcesListSqlUserDefinedFunctionsOperation(),
        new SqlResourcesMigrateSqlContainerToAutoscaleOperation(),
        new SqlResourcesMigrateSqlContainerToManualThroughputOperation(),
        new SqlResourcesMigrateSqlDatabaseToAutoscaleOperation(),
        new SqlResourcesMigrateSqlDatabaseToManualThroughputOperation(),
        new SqlResourcesUpdateSqlContainerThroughputOperation(),
        new SqlResourcesUpdateSqlDatabaseThroughputOperation(),
        new TableResourcesCreateUpdateTableOperation(),
        new TableResourcesDeleteTableOperation(),
        new TableResourcesGetTableOperation(),
        new TableResourcesGetTableThroughputOperation(),
        new TableResourcesListTablesOperation(),
        new TableResourcesMigrateTableToAutoscaleOperation(),
        new TableResourcesMigrateTableToManualThroughputOperation(),
        new TableResourcesUpdateTableThroughputOperation(),
    };
}
