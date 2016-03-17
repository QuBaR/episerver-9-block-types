using System.Web.Mvc;
using episerver9_tutorial.Models.Blocks;
using EPiServer.Web.Mvc;

namespace episerver9_tutorial.Controllers
{
    public class JumbotronBlockController : BlockController<JumbotronBlock>
    {
        public override ActionResult Index(JumbotronBlock currentblock)
        {
            return PartialView(currentblock);
        }
         
    }
}