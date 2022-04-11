using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;


public static class MongoDBHelper
{
    private static string _connectionString = "mongodb+srv://eBisOperator:HARDpassword@cluster0.vzvci.mongodb.net/eBis?retryWrites=true&w=majority";
    public static MongoClient MongoClient = new MongoClient(_connectionString); //connexion à mongo
    public static IMongoDatabase eBisMongoBase = MongoClient.GetDatabase("eBis"); //connexion BDD
}