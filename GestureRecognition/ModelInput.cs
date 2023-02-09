using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Data;
namespace GestureRecognition
{
    class ModelInput
    {
        [ColumnName("Label"), LoadColumn(0)]
        public string Label { get; set; }
        [ColumnName("ImageSource"), LoadColumn(1)]
        public string ImageSource { get; set; }
    }
}
