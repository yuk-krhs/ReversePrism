using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 defaultRackId                            int IL2CPP_TYPE_I4
    // 000 IllegalRackId                            int IL2CPP_TYPE_I4
    // 020 RackId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 HasExistingRackId                        000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class CriAtomExAsrRack
    {
        public int                                      RackId                                  { get; set; }
        public bool                                     HasExistingRackId                       { get; set; }

        public static CriAtomExAsrRack? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriAtomExAsrRack();

            value.RackId                                    = GetInt32(new IntPtr(p + 0x020)); // 0270DAC2A440 0x20 RackId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.HasExistingRackId                         = GetBool(new IntPtr(p + 0x024)); // 0270DAC2A460 0x24 HasExistingRackId           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
