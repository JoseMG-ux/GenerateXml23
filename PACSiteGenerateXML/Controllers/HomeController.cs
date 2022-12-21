using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nancy.Json;
using Newtonsoft.Json;
using PACSiteGenerateXML.Models;
using System.Collections;

namespace PACSiteGenerateXML.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Modal()
        {
            return View();
        }

        public IActionResult ViewOpInterna()
        {
            return View();
        }

        public IActionResult ViewInfoEmisor()
        {
            Selects modeloSuper = new();

            StreamReader readerProvincias = new StreamReader("./json/CatalogoProvincias.json");
            string jsonStringPr = readerProvincias.ReadToEnd();
            List<Provincias> provincias = JsonConvert.DeserializeObject<List<Provincias>>(jsonStringPr);

            modeloSuper.Provincias = provincias;

            return View(modeloSuper);
        }

        public ActionResult<Selects> ViewInfoReceptor(string codigoProvincia)
        {
            Selects modeloSuper = new();

            #region StreamReader
            StreamReader readerPaises = new StreamReader("./json/CatalogoPaises.json");
            StreamReader readerProvincias = new StreamReader("./json/CatalogoProvincias.json");
            //StreamReader readerCorregimientos = new StreamReader("./json/CatalogoCorregimientos.json");
            StreamReader readerDistritos = new StreamReader("./json/CatalogoDistritos.json");

            string jsonStringPa = readerPaises.ReadToEnd();
            string jsonStringPr = readerProvincias.ReadToEnd();
            //string jsonStringC = readerCorregimientos.ReadToEnd();
            string jsonStringD = readerDistritos.ReadToEnd();
            #endregion

            List<Paises> paises = JsonConvert.DeserializeObject<List<Paises>>(jsonStringPa);

            List<Provincias> provincias = JsonConvert.DeserializeObject<List<Provincias>>(jsonStringPr);

            //Corregimientos[] corregimientos = JsonConvert.DeserializeObject<Corregimientos[]>(jsonStringC);

            List<Distritos> distritos = JsonConvert.DeserializeObject<List<Distritos>>(jsonStringD);

            List<Distritos> distritosSeleccionados = distritos.Where(x => x.codigo.Split("-")[0] == codigoProvincia).ToList();
            
            modeloSuper.Paises = paises;
            modeloSuper.Provincias = provincias;
            modeloSuper.Distritos = distritosSeleccionados;
            //modeloSuper.Corregimientos = corregimientos;
            return View(modeloSuper);
        }

        public IActionResult ViewRegistrarItem()
        {
            return View();
        }

        public IActionResult ViewInfoItem()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}