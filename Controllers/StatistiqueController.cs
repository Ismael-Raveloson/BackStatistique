using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using statistique;

namespace statistique.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class StatistiqueController : Controller
    {
        [HttpGet("selectStatGeneral")]
        public IActionResult Index()
        {
            StatistiqueModel stat = new StatistiqueModel();
            List<StatistiqueModel> statgeneral = stat.StatGeneral();
            return Json(statgeneral);
        } 

        [HttpGet("selectStatGeneraDomicile")]
        public IActionResult StatGenDom()
        {
            StatistiqueModel stat = new StatistiqueModel();
            List<StatistiqueModel> statgeneral = stat.StatGeneralDomicile();
            return Json(statgeneral);
        } 

        [HttpGet("selectStatGeneraExterieur")]
        public IActionResult StatGenExt()
        {
            StatistiqueModel stat = new StatistiqueModel();
            List<StatistiqueModel> statgeneral = stat.StatGeneralExterieur();
            return Json(statgeneral);
        } 

        [HttpGet("selectStatDenfenseDomicile")]
        public IActionResult StatDefDom()
        {
            StatistiqueModel stat = new StatistiqueModel();
            List<StatistiqueModel> statgeneral = stat.StatDefDom();
            return Json(statgeneral);
        } 

        [HttpGet("selectStatDenfenseExterieur")]
        public IActionResult StatDefExt()
        {
            StatistiqueModel stat = new StatistiqueModel();
            List<StatistiqueModel> statgeneral = stat.StatDefExt();
            return Json(statgeneral);
        } 

        [HttpGet("selectStatDenfenseGeneral")]
        public IActionResult StatDefGen()
        {
            StatistiqueModel stat = new StatistiqueModel();
            List<StatistiqueModel> statgeneral = stat.StatDefGen();
            return Json(statgeneral);
        } 

        [HttpGet("selectStatAttaqueDomicile")]
        public IActionResult StatAttDom()
        {
            StatistiqueModel stat = new StatistiqueModel();
            List<StatistiqueModel> statgeneral = stat.StatAttDom();
            return Json(statgeneral);
        } 

        [HttpGet("selectStatAttaqueExterieur")]
        public IActionResult StatExt()
        {
            StatistiqueModel stat = new StatistiqueModel();
            List<StatistiqueModel> statgeneral = stat.StatAttExt();
            return Json(statgeneral);
        } 
        
    }
}