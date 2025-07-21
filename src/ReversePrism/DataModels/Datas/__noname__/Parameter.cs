using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Ducker                                   ModelEnumType ReactDuckerParameter ReactDuckerParameter ReactDuckerParameter Int32
    // 010 AisacModulation                          ModelEnumType ReactAisacModulationParameter ReactAisacModulationParameter ReactAisacModulationParameter Int32
    public partial class Parameter : DataModel
    {
        public ReactDuckerParameter                     Ducker                                  { get; set; }
        public ReactAisacModulationParameter            AisacModulation                         { get; set; }

        public static Parameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Parameter() { Pointer= p0 };

            value.Ducker                                    = (ReactDuckerParameter)GetInt32(new IntPtr(p + 0x010)); // 0x10 Ducker                      ( ModelEnumType ReactDuckerParameter ReactDuckerParameter ReactDuckerParameter Int32 )
            value.AisacModulation                           = (ReactAisacModulationParameter)GetInt32(new IntPtr(p + 0x010)); // 0x10 AisacModulation             ( ModelEnumType ReactAisacModulationParameter ReactAisacModulationParameter ReactAisacModulationParameter Int32 )

            return value;
        }
    }
}
