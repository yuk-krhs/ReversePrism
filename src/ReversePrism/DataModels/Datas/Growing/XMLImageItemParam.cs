using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ImageUrl                                 ModelPrimitiveType string string string String
    // 028 <width>k__BackingField                   Nullable`1<float> IL2CPP_TYPE_GENERICINST
    // 030 <height>k__BackingField                  Nullable`1<float> IL2CPP_TYPE_GENERICINST
    // 038 Tex2d                                    ModelClassType Texture2D Texture2D Texture2D Pointer
    public partial class XMLImageItemParam : DataModel
    {
        public string                                   ImageUrl                                { get; set; }
        public Texture2D?                               Tex2d                                   { get; set; }

        public static XMLImageItemParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XMLImageItemParam() { Pointer= p0 };

            value.ImageUrl                                  = GetString(new IntPtr(p + 0x020)); // 0x20 ImageUrl                    ( ModelPrimitiveType string string string String )
            value.Tex2d                                     = GetObject<Texture2D>(new IntPtr(p + 0x038), ReversePrism.DataModels.Texture2D.FromPointer); // 0x38 Tex2d                       ( ModelClassType Texture2D Texture2D Texture2D Pointer )

            return value;
        }
    }
}
