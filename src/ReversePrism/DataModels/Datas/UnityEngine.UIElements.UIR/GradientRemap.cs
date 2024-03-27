using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 OrigIndex                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C DestIndex                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 Location                                 000186651230 ModelEnumType RectInt RectInt RectInt Int32
    // 030 Next                                     00018668F220 ModelClassType GradientRemap GradientRemap GradientRemap Pointer
    // 038 Atlas                                    000186688130 ModelEnumType TextureId TextureId TextureId Int32
    public partial class GradientRemap
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
            var value   = new GradientRemap();

            value.OrigIndex                                 = GetInt32(new IntPtr(p + 0x018)); // 02700687B6A8 0x18 OrigIndex                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.DestIndex                                 = GetInt32(new IntPtr(p + 0x01C)); // 02700687B6C8 0x1C DestIndex                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Location                                  = (RectInt)GetInt32(new IntPtr(p + 0x020)); // 02700687B6E8 0x20 Location                    ( 000186651230 ModelEnumType RectInt RectInt RectInt Int32 )
            value.Next                                      = GetObject<GradientRemap>(new IntPtr(p + 0x030), ReversePrism.DataModels.GradientRemap.FromPointer); // 02700687B708 0x30 Next                        ( 00018668F220 ModelClassType GradientRemap GradientRemap GradientRemap Pointer )
            value.Atlas                                     = (TextureId)GetInt32(new IntPtr(p + 0x038)); // 02700687B728 0x38 Atlas                       ( 000186688130 ModelEnumType TextureId TextureId TextureId Int32 )

            return value;
        }
    }
}
