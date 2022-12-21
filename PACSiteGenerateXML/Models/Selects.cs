namespace PACSiteGenerateXML.Models
{
    public class Selects
    {
        public List<Paises> Paises { get; set; }
        public List<Corregimientos> Corregimientos { get; set; }
        //public List<Distritos> Distritos { get; set; }
        public List<Distritos> Distritos { get; set; }
        public List<Provincias> Provincias { get; set; }
        public List<DistritosSeleccionados> DistritosSeleccionados { get; set; }
    }
}
