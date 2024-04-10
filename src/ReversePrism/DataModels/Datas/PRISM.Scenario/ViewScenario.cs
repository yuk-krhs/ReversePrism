using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 ScenarioScene                            000186671910 ModelPrimitiveType string string string String
    // 060 Parameter                                000186523990 ModelClassType ViewScenarioParameter ViewScenarioParameter ViewScenarioParameter Pointer
    public partial class ViewScenario : DataModel
    {
        public string                                   ScenarioScene                           { get; set; }
        public ViewScenarioParameter?                   Parameter                               { get; set; }

        public static ViewScenario? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ViewScenario() { Pointer= p0 };

            value.ScenarioScene                             = GetString(new IntPtr(p + 0x058)); // 024665E690C8 0x58 ScenarioScene               ( 000186671910 ModelPrimitiveType string string string String )
            value.Parameter                                 = GetObject<ViewScenarioParameter>(new IntPtr(p + 0x060), ReversePrism.DataModels.ViewScenarioParameter.FromPointer); // 024665E690E8 0x60 Parameter                   ( 000186523990 ModelClassType ViewScenarioParameter ViewScenarioParameter ViewScenarioParameter Pointer )

            return value;
        }
    }
}
