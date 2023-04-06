Imports MongoDB.Bson
Imports MongoDB.Driver

Module MongoDB
    Public Function MongoConnect(ByVal connectionString As String, ByVal databaseName As String)
        ' Create a MongoClient object and connect to the MongoDB database
        Dim client As New MongoClient(connectionString) 'mongodb://localhost
        Dim database As IMongoDatabase = client.GetDatabase(databaseName)
        Return database
    End Function
    Public Function getPatients(ByVal database As IMongoDatabase, ByVal collectionName As String)
        ' Retrieve the data from the MongoDB database
        Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionName)
        Dim cursor As IFindFluent(Of BsonDocument, BsonDocument) = collection.Find(New BsonDocument)
        Dim patients As List(Of BsonDocument) = cursor.ToList
        Return patients
    End Function

    Public Function getVisits(ByVal database As IMongoDatabase, ByVal collectionName As String)
        ' Retrieve the data from the MongoDB database
        Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionName)
        Dim cursor As IFindFluent(Of BsonDocument, BsonDocument) = collection.Find(New BsonDocument)
        Dim visits As List(Of BsonDocument) = cursor.ToList
        Return visits
    End Function
End Module
