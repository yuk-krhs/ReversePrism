using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Rgba                                     ModelEnumListType Color32[] Color32[] List<Color32> Pointer
    // 018 Width                                    ModelPrimitiveType int int int Int32
    // 01C Height                                   ModelPrimitiveType int int int Int32
    public partial class RawTexture : DataModel
    {
        public List<Color32>?                           Rgba                                    { get; set; }
        public int                                      Width                                   { get; set; }
        public int                                      Height                                  { get; set; }

        public static RawTexture? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RawTexture() { Pointer= p0 };

            value.Rgba                                      = GetEnumList<Color32>(new IntPtr(p + 0x010)); // 0x10 Rgba                        ( ModelEnumListType Color32[] Color32[] List<Color32> Pointer )
            value.Width                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 Width                       ( ModelPrimitiveType int int int Int32 )
            value.Height                                    = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Height                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
