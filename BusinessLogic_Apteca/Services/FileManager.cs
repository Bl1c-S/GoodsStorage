using Newtonsoft.Json;
using System.IO;
using System;
using BusinessLogic_Apteca.Models;

namespace BusinessLogic_Apteca.Services;

public class FileManager<T> where T : ModelBase
{
     public void Create(T data)
     {
          string jsonData = JsonConvert.SerializeObject(data);
          File.WriteAllText(data.FilePath, jsonData);
     }
     public bool Delete(string filePath)
     {
          if (!File.Exists(filePath))
               return false;

          File.Delete(filePath);
          return true;
     }
     public T? Get(string filePath)
     {
          if (!File.Exists(filePath))
               return null;

          string jsonData = File.ReadAllText(filePath);
          T? deresializedData = JsonConvert.DeserializeObject<T>(jsonData);
          if (deresializedData == null)
               return null;

          deresializedData.FilePath = filePath;
          return deresializedData;
     }

     public List<T> GetAll(string directoryFilePath)
     {
          if (!Directory.Exists(directoryFilePath))
               throw new Exception($"this directory not found: {directoryFilePath}");

          List<string> filePaths = new(Directory.GetFiles(directoryFilePath));
          List<T> responseList = new();

          foreach (var modelFilePath in filePaths)
          {
               T? data = Get(modelFilePath);
               if (data != null)
                    responseList.Add(data);
          }
          return responseList;
     }
}