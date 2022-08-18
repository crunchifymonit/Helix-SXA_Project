using Sitecore.Data.Fields;

namespace HelixSetupSolution.Project.StandBlog.Model
{
    public class LinkInfo
    {
        public string url { get; set; }
        public string text { get; set; }
        public string title { get; set; }
        public string anchor { get; set; }
        public string target { get; set; }

        public LinkInfo() { }

        public LinkInfo(LinkField item)
        {
            url = item.GetFriendlyUrl();
            text = item.Text;
            title = item.Title;
            anchor = item.Anchor;
            target = item.Target;
        }
    }
}