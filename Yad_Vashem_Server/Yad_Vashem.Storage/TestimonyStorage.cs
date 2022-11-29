using Newtonsoft.Json;
using Yad_Vashem.Service.Interfaces;
using Yad_Vashem.Entities;

namespace Yad_Vashem.Storage;
public class TestimonyStorage: ITestimonyStorage
{
    public async Task<Testimony> getTestimonyInfo()
    {
        Testimony? testimony = await ReadFromTestimonyFile();
        if (testimony != null)
        {
            return testimony;
        }
        else
        {
            throw new Exception("File is empty");
        }
    }
    public async Task<Resource> getTestimonyResourceByType(ResourceType type)
    {
        Testimony? testimony = await ReadFromTestimonyFile();
        if(testimony != null)
        { 
            return testimony.Resources.Where(resource => resource.Type == type).ToList()[0];
        }
        else
        {
            throw new Exception("File is empty");
        }
    }
    private async Task<Testimony?> ReadFromTestimonyFile()
    {
        try
        {
            using (StreamReader reader = new StreamReader("../Yad_Vashem.Storage/עדות.json"))
            {
                string _testimony;
                _testimony = await reader.ReadToEndAsync();
                if (_testimony != null)
                {
                    return JsonConvert.DeserializeObject<Testimony>(_testimony);
                }
                return null;
            }
        }
        catch(Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}