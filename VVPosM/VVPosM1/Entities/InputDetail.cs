using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVPosM1.Entities
{
    public class InputDetail
    {
        public string InputId { get; set; }
        public string IngredientId { get; set; }
        public string IngredientExpDate { get; set; }
        public string IngredientQty { get; set; }
        public string IngredientPrice { get; set; }
        public string IngredientVat { get; set; }
        public string IngredientDiscount { get; set; }
    }
}
