using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StreamType                               ModelEnumType StreamType StreamType StreamType Int32
    // 014 EnableSpatialAudio                       ModelPrimitiveType bool bool bool Bool
    public partial class PlatformConfigAndroid : DataModel
    {
        public StreamType                               StreamType                              { get; set; }
        public bool                                     EnableSpatialAudio                      { get; set; }

        public static PlatformConfigAndroid? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlatformConfigAndroid() { Pointer= p0 };

            value.StreamType                                = (StreamType)GetInt32(new IntPtr(p + 0x010)); // 0x10 StreamType                  ( ModelEnumType StreamType StreamType StreamType Int32 )
            value.EnableSpatialAudio                        = GetBool(new IntPtr(p + 0x014)); // 0x14 EnableSpatialAudio          ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
