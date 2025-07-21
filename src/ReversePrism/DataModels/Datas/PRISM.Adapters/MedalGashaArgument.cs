using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EventId                                  ModelPrimitiveType int int int Int32
    // 014 GashaId                                  ModelPrimitiveType int int int Int32
    public partial class MedalGashaArgument : DataModel
    {
        public int                                      EventId                                 { get; set; }
        public int                                      GashaId                                 { get; set; }

        public static MedalGashaArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalGashaArgument() { Pointer= p0 };

            value.EventId                                   = GetInt32(new IntPtr(p + 0x010)); // 0x10 EventId                     ( ModelPrimitiveType int int int Int32 )
            value.GashaId                                   = GetInt32(new IntPtr(p + 0x014)); // 0x14 GashaId                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
