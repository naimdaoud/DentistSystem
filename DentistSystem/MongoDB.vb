Imports MongoDB.Bson
Imports MongoDB.Driver

Module MongoDB
    Public Function MongoConnect(ByVal connectionString As String, ByVal databaseName As String)
        ' Create a MongoClient object and connect to the MongoDB database
        Dim client As New MongoClient(connectionString) 'mongodb://localhost
        Dim database As IMongoDatabase = client.GetDatabase(databaseName)
        Return database
    End Function
    Public Function getCollection(ByVal database As IMongoDatabase, ByVal collectionName As String)
        ' Retrieve the data from the MongoDB database
        Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionName)
        Dim cursor As IFindFluent(Of BsonDocument, BsonDocument) = collection.Find(New BsonDocument)
        Dim col As List(Of BsonDocument) = cursor.ToList
        Return col
    End Function
    Public Function getPatientVisits(ByVal database As IMongoDatabase, ByVal patientId As String)
        Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)("Visits")
        Dim filter As BsonDocument = New BsonDocument("patientId", patientId)
        Dim sort As SortDefinition(Of BsonDocument) = Builders(Of BsonDocument).Sort.Ascending("name")
        Dim cursor As IFindFluent(Of BsonDocument, BsonDocument) = collection.Find(filter).Sort(sort)
        Dim visits As List(Of BsonDocument) = cursor.ToList
        Return visits
    End Function
    Public Function getPatientInformation(ByVal patientId As String, ByVal database As IMongoDatabase)
        Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)("Patients")
        Dim objectId As ObjectId = New ObjectId(patientId)
        Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of ObjectId)("_id", objectId)
        Dim document As BsonDocument = collection.Find(filter).FirstOrDefault()
        Return document
    End Function
    Public Function getVisitInformation(ByVal visitId As String, ByVal database As IMongoDatabase)
        Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)("Visits")
        Dim objectId As ObjectId = New ObjectId(visitId)
        Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of ObjectId)("_id", objectId)
        Dim document As BsonDocument = collection.Find(filter).FirstOrDefault()
        Return document
    End Function
    Public Function addPatient(ByVal database As IMongoDatabase, ByVal name As String, Optional ByVal mobileNumber As String = "", Optional ByVal dateOfBirth As String = "", Optional ByVal caseDescription As String = "")
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)("Patients")
            Dim document As New BsonDocument()
            document.Add("name", name)
            document.Add("mobileNumber", mobileNumber)
            document.Add("dateOfBirth", dateOfBirth)
            document.Add("caseDescription", caseDescription)
            Dim result = collection.InsertOneAsync(document)
            Return result.Status
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
    Public Function addVisit(ByVal database As IMongoDatabase, ByVal number As String, ByVal visitDate As String, ByVal visitType As String, ByVal patientId As String, Optional ByVal amountPaid As String = "", Optional ByVal notes As String = "")
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)("Visits")
            Dim document As New BsonDocument()
            document.Add("number", number)
            document.Add("date", visitDate)
            document.Add("visitType", visitType)
            document.Add("patientId", patientId)
            document.Add("amountPaid", amountPaid)
            document.Add("notes", notes)
            Dim result = collection.InsertOneAsync(document)
            Return result.Status
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
End Module
