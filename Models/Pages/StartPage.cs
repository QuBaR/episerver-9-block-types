using EPiServer.Core;
using EPiServer.DataAnnotations;

namespace episerver9_tutorial.Models.Pages
{
    [ContentType]
    public class StartPage : PageData
    {
        public virtual string Heading { get; set; }
        public virtual XhtmlString MainBody { get; set; }
        public virtual ContentArea MainContentArea { get; set; }
    }
}