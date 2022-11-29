
namespace Yad_Vashem.Entities;
public class Element
{
    public string? Title { get; set; }
    public ResourceElementValue[]? Value { get; set; }
    public Pointer[]? Pointers { get; set; }
    public Place[]? Places { get; set; }
    public string? Id { get; set; }
    public int? Level { get; set; }
    public string? FileCount { get; set; }
    public bool? HasChildren { get; set; }
    public Element[]? Children { get; set; }
}
