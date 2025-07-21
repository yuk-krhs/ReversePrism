using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CueName                                  ModelPrimitiveType string string string String
    // 018 Label                                    ModelPrimitiveType int int int Int32
    // 01C IsSubSeason                              ModelPrimitiveType bool bool bool Bool
    public partial class ProduceTopBgmVolumeAdjuster : DataModel
    {
        public string                                   CueName                                 { get; set; }
        public int                                      Label                                   { get; set; }
        public bool                                     IsSubSeason                             { get; set; }

        public static ProduceTopBgmVolumeAdjuster? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceTopBgmVolumeAdjuster() { Pointer= p0 };

            value.CueName                                   = GetString(new IntPtr(p + 0x010)); // 0x10 CueName                     ( ModelPrimitiveType string string string String )
            value.Label                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 Label                       ( ModelPrimitiveType int int int Int32 )
            value.IsSubSeason                               = GetBool(new IntPtr(p + 0x01C)); // 0x1C IsSubSeason                 ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
