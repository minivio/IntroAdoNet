using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedicoWab.Controllers
{
    public class AjaxController : Controller
    {
        // GET: Ajax
        public string Index()
        {
            return "coucou";
        }

        public string Img()
        {
            return "http://www.vulgaris-medical.com/sites/default/files/styles/big-lightbox/public/field/image/actualites/2016/02/12/le-chat-source-de-bienfaits-pour-votre-sante.jpg";
        }
    }
}