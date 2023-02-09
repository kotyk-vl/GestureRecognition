using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestureRecognition
{
    class ConsumeModel
    {
        private static Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictionEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(CreatePredictionEngine);
        public static ModelOutput Predict(ModelInput input)
        {
            ModelOutput result = PredictionEngine.Value.Predict(input);
            return result;
        }
        public static PredictionEngine<ModelInput, ModelOutput> CreatePredictionEngine()
        {
            MLContext mlContext = new MLContext();
            string modelPath = String.Format(@"{0}MLModel.zip", System.IO.Path.GetFullPath(@"..//"));
            if (File.Exists(modelPath) == false)
            {
                MessageBox.Show("Model doesn't exist", "Warning", MessageBoxButtons.OK);
                return null;
            }
            else
            {
                ITransformer mlModel = mlContext.Model.Load(modelPath, out var modelInputSchema);
                var predEngine = mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
                return predEngine;
            }
        }
    }
}
