using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Ducker                                   00018654AD80 ModelEnumType ReactDuckerParameter ReactDuckerParameter ReactDuckerParameter Int32
    // 010 AisacModulation                          00018654A310 ModelEnumType ReactAisacModulationParameter ReactAisacModulationParameter ReactAisacModulationParameter Int32
    public partial class Parameter
    {
        public ReactDuckerParameter                     Ducker                                  { get; set; }
        public ReactAisacModulationParameter            AisacModulation                         { get; set; }

        public static Parameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Parameter();

            value.Ducker                                    = (ReactDuckerParameter)GetInt32(new IntPtr(p + 0x010)); // 0270DAC6E820 0x10 Ducker                      ( 00018654AD80 ModelEnumType ReactDuckerParameter ReactDuckerParameter ReactDuckerParameter Int32 )
            value.AisacModulation                           = (ReactAisacModulationParameter)GetInt32(new IntPtr(p + 0x010)); // 0270DAC6E840 0x10 AisacModulation             ( 00018654A310 ModelEnumType ReactAisacModulationParameter ReactAisacModulationParameter ReactAisacModulationParameter Int32 )

            return value;
        }
    }
}
