using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 App                                      ModelPrimitiveType string string string String
    // 018 Version                                  ModelPrimitiveType string string string String
    // 020 Image                                    ModelPrimitiveType string string string String
    // 028 Format                                   ModelPrimitiveType string string string String
    // 030 Size                                     ModelEnumType SpriteSize SpriteSize SpriteSize Int32
    // 038 Scale                                    ModelPrimitiveType float float float Single
    // 040 Smartupdate                              ModelPrimitiveType string string string String
    public partial class Meta : DataModel
    {
        public string                                   App                                     { get; set; }
        public string                                   Version                                 { get; set; }
        public string                                   Image                                   { get; set; }
        public string                                   Format                                  { get; set; }
        public SpriteSize                               Size                                    { get; set; }
        public float                                    Scale                                   { get; set; }
        public string                                   Smartupdate                             { get; set; }

        public static Meta? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Meta() { Pointer= p0 };

            value.App                                       = GetString(new IntPtr(p + 0x010)); // 0x10 App                         ( ModelPrimitiveType string string string String )
            value.Version                                   = GetString(new IntPtr(p + 0x018)); // 0x18 Version                     ( ModelPrimitiveType string string string String )
            value.Image                                     = GetString(new IntPtr(p + 0x020)); // 0x20 Image                       ( ModelPrimitiveType string string string String )
            value.Format                                    = GetString(new IntPtr(p + 0x028)); // 0x28 Format                      ( ModelPrimitiveType string string string String )
            value.Size                                      = (SpriteSize)GetInt32(new IntPtr(p + 0x030)); // 0x30 Size                        ( ModelEnumType SpriteSize SpriteSize SpriteSize Int32 )
            value.Scale                                     = GetSingle(new IntPtr(p + 0x038)); // 0x38 Scale                       ( ModelPrimitiveType float float float Single )
            value.Smartupdate                               = GetString(new IntPtr(p + 0x040)); // 0x40 Smartupdate                 ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
