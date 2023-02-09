using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Data;

namespace GestureRecognition
{
    public class LoadModel
    {
        public static float PredictScore { get; set; }
        public static string PredictLabel { get; set; }
        public static string Meth(string path)
        {
            StringBuilder sb = new StringBuilder();
            ModelInput sampleData;
            try
            {
                sampleData = new ModelInput()
                {
                    ImageSource = path,
                };
            }
            catch (Exception)
            {

                throw new Exception("Incorect adress");
            }
            var predictionResult = ConsumeModel.Predict(sampleData);
            predictionResult.Prediction = predictionResult.Score.Max() < 0.5f ? "Non-identify" : predictionResult.Prediction ;
            PredictScore = predictionResult.Score.Max();
            PredictLabel = predictionResult.Prediction;
            sb.AppendFormat($"Predicted Label:{ PredictLabel}");
            sb.AppendLine();
            sb.AppendFormat($"Predicted score: {PredictScore: ##.# %}");
            sb.AppendLine();
            return sb.ToString();
        }

    }
}
