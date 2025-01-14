namespace FMUI.Presentation;
using LiveChartsCore; 
using LiveChartsCore.SkiaSharpView; 
public partial record SecondModel(Entity Entity)
{
    public ISeries[] Series { get; set; }  
        = new ISeries[] 
        { 
            new LineSeries<double> 
            { 
                Values = new double[] { 2, 1, 3, 5, 3, 4, 6 }, 
                Fill = null 
            } 
        }; 
}
