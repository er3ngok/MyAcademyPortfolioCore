namespace Portfolio.Web.Entities
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public string GithubURL { get; set; }

        //navigation property
        public Category Category { get; set; }
    }
}
