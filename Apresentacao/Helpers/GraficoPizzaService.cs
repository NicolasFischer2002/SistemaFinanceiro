using System.Windows.Forms.DataVisualization.Charting;

namespace SistemaFinanceiro.Apresentacao.Helpers
{
    internal class GraficoPizzaService
    {
        public static void InicializarExistente(Chart chart, Dictionary<string, double> dados)
        {
            // 1) Limpa o chart de anteriores
            chart.Series.Clear();
            chart.ChartAreas.Clear();
            chart.Legends.Clear();

            // 2) Área do gráfico
            var area = new ChartArea("Default");
            chart.ChartAreas.Add(area);

            // 3) Série de dados configurada como pizza
            var series = new Series("Categorias")
            {
                ChartType = SeriesChartType.Pie,
                Label = "#PERCENT{P0}",    // mostra percentuais
                LegendText = "#VALX (#VALY)",   // texto na legenda
                BorderWidth = 1,
                BorderColor = Color.Gray
            };

            foreach (var kvp in dados)
                series.Points.AddXY(kvp.Key, kvp.Value);

            chart.Series.Add(series);

            // 4) Legenda ao lado direito
            chart.Legends.Add(new Legend
            {
                Docking = Docking.Right,
                Alignment = StringAlignment.Center
            });

            // 5) Aparência geral
            chart.BackColor = Color.White;
            chart.Dock = DockStyle.Fill;
        }
    }
}