using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EventId                                  0001865F4260 ModelPrimitiveType int int int Int32
    // 014 GashaId                                  0001865F4260 ModelPrimitiveType int int int Int32
    public partial class MedalGashaParameter
    {
        public int                                      EventId                                 { get; set; }
        public int                                      GashaId                                 { get; set; }

        public static MedalGashaParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalGashaParameter();

            value.EventId                                   = GetInt32(new IntPtr(p + 0x010)); // 0270D512BF40 0x10 EventId                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.GashaId                                   = GetInt32(new IntPtr(p + 0x014)); // 0270D512BF60 0x14 GashaId                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
