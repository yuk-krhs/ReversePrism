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
    // 020 RackId                                   ModelPrimitiveType int int int Int32
    // 024 HasExistingRackId                        ModelPrimitiveType bool bool bool Bool
    public partial class CriAtomExAsrRack : DataModel
    {
        public int                                      RackId                                  { get; set; }
        public bool                                     HasExistingRackId                       { get; set; }

        public static CriAtomExAsrRack? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriAtomExAsrRack() { Pointer= p0 };

            value.RackId                                    = GetInt32(new IntPtr(p + 0x020)); // 0x20 RackId                      ( ModelPrimitiveType int int int Int32 )
            value.HasExistingRackId                         = GetBool(new IntPtr(p + 0x024)); // 0x24 HasExistingRackId           ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
