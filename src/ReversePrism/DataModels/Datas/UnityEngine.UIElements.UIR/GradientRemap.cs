using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 OrigIndex                                ModelPrimitiveType int int int Int32
    // 01C DestIndex                                ModelPrimitiveType int int int Int32
    // 020 Location                                 ModelEnumType RectInt RectInt RectInt Int32
    // 030 Next                                     ModelClassType GradientRemap GradientRemap GradientRemap Pointer
    // 038 Atlas                                    ModelEnumType TextureId TextureId TextureId Int32
    public partial class GradientRemap : DataModel
    {
        public int                                      OrigIndex                               { get; set; }
        public int                                      DestIndex                               { get; set; }
        public RectInt                                  Location                                { get; set; }
        public GradientRemap?                           Next                                    { get; set; }
        public TextureId                                Atlas                                   { get; set; }

        public static GradientRemap? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GradientRemap() { Pointer= p0 };

            value.OrigIndex                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 OrigIndex                   ( ModelPrimitiveType int int int Int32 )
            value.DestIndex                                 = GetInt32(new IntPtr(p + 0x01C)); // 0x1C DestIndex                   ( ModelPrimitiveType int int int Int32 )
            value.Location                                  = (RectInt)GetInt32(new IntPtr(p + 0x020)); // 0x20 Location                    ( ModelEnumType RectInt RectInt RectInt Int32 )
            value.Next                                      = GetObject<GradientRemap>(new IntPtr(p + 0x030), ReversePrism.DataModels.GradientRemap.FromPointer); // 0x30 Next                        ( ModelClassType GradientRemap GradientRemap GradientRemap Pointer )
            value.Atlas                                     = (TextureId)GetInt32(new IntPtr(p + 0x038)); // 0x38 Atlas                       ( ModelEnumType TextureId TextureId TextureId Int32 )

            return value;
        }
    }
}
