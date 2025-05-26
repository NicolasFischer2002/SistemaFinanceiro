namespace SistemaFinanceiro.Entidades
{
    public class Datas
    {
        public DateTime DataInicial { get; private set; }
        public DateTime DataFinal { get; private set; }

        public Datas(DateTime? dataInicial = null, DateTime? dataFinal = null)
        {
            AtribuirDatas(dataInicial, dataFinal);
        }

        private void AtribuirDatas(DateTime? dataInicial, DateTime? dataFinal)
        {
            if (dataInicial is null)
                AtribuirPrimeiroDiaMesCorrenteDataInicial();
            else
                DataInicial = (DateTime)dataInicial;

            if (dataFinal is null)
                AtribuirUltimoDiaMesCorrenteDataFinal();
            else
                DataFinal = (DateTime)dataFinal;
        }

        private void AtribuirPrimeiroDiaMesCorrenteDataInicial()
        {
            var hoje = DateTime.Today;
            DataInicial = new DateTime(hoje.Year, hoje.Month, 1);
        }

        private void AtribuirUltimoDiaMesCorrenteDataFinal()
        {
            var hoje = DateTime.Today;
            DateTime primeiroDia = new DateTime(hoje.Year, hoje.Month, 1);
            DataFinal = primeiroDia.AddMonths(1).AddDays(-1);
        }
    }
}