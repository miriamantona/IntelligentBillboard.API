namespace AppspaceChallenge.API.DTO.Output
{
  public class DocumentaryRecommendation: IRecommendation
  {
    public string Title { get; set; }
    public string Overview { get; set; }
    public ICollection<string> Genres { get; set; }
    public string Language { get; set; }
    public DateTime? ReleaseDate { get; set; }
    public string Website { get; set; }
    public ICollection<string> Keywords { get; set; }
  }
}
