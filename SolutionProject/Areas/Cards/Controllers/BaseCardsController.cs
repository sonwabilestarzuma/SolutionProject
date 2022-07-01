using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.Areas.Cards.Controllers
{
    [Area("Cards")]
    [Route("[area]/[action]/{id?}")]
    public abstract class BaseCardsController : Controller
    {
    }
}