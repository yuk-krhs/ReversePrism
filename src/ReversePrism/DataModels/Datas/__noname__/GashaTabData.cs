using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Index                                    ModelPrimitiveType int int int Int32
    // 018 GashaId                                  ModelPrimitiveType string string string String
    public partial class GashaTabData : DataModel
    {
        public int                                      Index                                   { get; set; }
        public string                                   GashaId                                 { get; set; }

        public static GashaTabData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaTabData() { Pointer= p0 };

            value.Index                                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 Index                       ( ModelPrimitiveType int int int Int32 )
            value.GashaId                                   = GetString(new IntPtr(p + 0x018)); // 0x18 GashaId                     ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
