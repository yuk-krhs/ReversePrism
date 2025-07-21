using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsFromTitle                              ModelPrimitiveType bool bool bool Bool
    // 011 IsFromOurStream                          ModelPrimitiveType bool bool bool Bool
    // 012 IsFromCostumeChangeView                  ModelPrimitiveType bool bool bool Bool
    // 014 MstOurStreamId                           ModelPrimitiveType int int int Int32
    // 018 <MstOurStreamArchiveId>k__BackingField   Nullable`1<int> IL2CPP_TYPE_GENERICINST
    public partial class LegacyHomeParameter : DataModel
    {
        public bool                                     IsFromTitle                             { get; set; }
        public bool                                     IsFromOurStream                         { get; set; }
        public bool                                     IsFromCostumeChangeView                 { get; set; }
        public int                                      MstOurStreamId                          { get; set; }

        public static LegacyHomeParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LegacyHomeParameter() { Pointer= p0 };

            value.IsFromTitle                               = GetBool(new IntPtr(p + 0x010)); // 0x10 IsFromTitle                 ( ModelPrimitiveType bool bool bool Bool )
            value.IsFromOurStream                           = GetBool(new IntPtr(p + 0x011)); // 0x11 IsFromOurStream             ( ModelPrimitiveType bool bool bool Bool )
            value.IsFromCostumeChangeView                   = GetBool(new IntPtr(p + 0x012)); // 0x12 IsFromCostumeChangeView     ( ModelPrimitiveType bool bool bool Bool )
            value.MstOurStreamId                            = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstOurStreamId              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
