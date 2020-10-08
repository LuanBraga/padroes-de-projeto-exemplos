namespace MetodoFabrica
{
    internal class Aviao : IVeiculo
    {
        private readonly string _tipo = "Avião";
        public string Tipo 
        {
            get => _tipo;
        }

        public string TipoEntrega => "aérea";
    }
}