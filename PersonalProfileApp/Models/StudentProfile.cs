namespace PersonalProfileApp.Models;

public class StudentProfile
{
    public string FullName { get; set; } = string.Empty;
    public string University { get; set; } = string.Empty;
    public string Group { get; set; } = string.Empty;
    public string Course { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Major { get; set; } = string.Empty;
    public List<string> Skills { get; set; } = [];
    public List<string> Interests {  get; set; } = [];
    public string? ContactInformation { get; set; }
    public List<PortfolioProject> Projects { get; set; } = [];
}


public class PortfolioProject
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<string> Technologies { get; set; } = [];
}
