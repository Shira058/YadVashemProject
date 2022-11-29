
namespace Yad_Vashem.Entities;
public class Resource
{
    public string Title { get; set; }
    public string? URL { get; set; }
    public string? URLTitle { get; set; }
    public ResourceType Type { get; set; }
    public Element[] Elements { get; set; }
}
