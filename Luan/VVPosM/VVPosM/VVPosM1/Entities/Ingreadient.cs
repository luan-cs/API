using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVPosM1.Entities
{
    public class Ingreadient
    {
        //`IngredientId``IngredientName``IngredientMeasure``IngredientExchange``IngredientUnit`
        public string IngredientId { get; set; }
        public string IngredientName { get; set; }
        public string IngredientMeasure { get; set; }
        public string IngredientExchange { get; set; }
        public string IngredientUnit { get; set; }
        public string IntakeUnit { get; set; }
    }
}
