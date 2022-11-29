namespace Yad_Vashem.Entities
{
    public class Testimony
    {
        public string Title { get; set; }
        public string Tag { get; set; }
        public string URL { get; set; }
        public string InfoText { get; set; }
        public bool IsTestimonies { get; set; }
        public TranscriptSTR[] TranscriptSTR { get; set; }
        public string? transcriptDOC { get; set; }
        public string? MoreInfo { get; set; }
        public string? Images { get; set; }
        public Resource[] Resources { get; set; }
    }
}