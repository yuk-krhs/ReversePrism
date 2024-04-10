using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ATLAS_PFIDOL_ICON_FRAME_RCT              string IL2CPP_TYPE_STRING
    // 008 ATLAS_PFIDOL_ICON_FRAME_SQ               string IL2CPP_TYPE_STRING
    // 010 ATLAS_PCARD                              000186674040 ModelPrimitiveType string string string String
    public partial class AtlasUtility : DataModel
    {
        public string                                   ATLAS_PCARD                             { get; set; }

        public static AtlasUtility? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AtlasUtility() { Pointer= p0 };

            value.ATLAS_PCARD                               = GetString(new IntPtr(p + 0x010)); // 024664F5A7F0 0x10 ATLAS_PCARD                 ( 000186674040 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
