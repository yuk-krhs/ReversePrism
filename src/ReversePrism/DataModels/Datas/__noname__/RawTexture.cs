using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Rgba                                     000185B75EB0 ModelEnumListType Color32[] Color32[] List<Color32> Pointer
    // 018 Width                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C Height                                   0001865F36C0 ModelPrimitiveType int int int Int32
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

            value.Rgba                                      = GetEnumList<Color32>(new IntPtr(p + 0x010)); // 0245A6825408 0x10 Rgba                        ( 000185B75EB0 ModelEnumListType Color32[] Color32[] List<Color32> Pointer )
            value.Width                                     = GetInt32(new IntPtr(p + 0x018)); // 0245A6825428 0x18 Width                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Height                                    = GetInt32(new IntPtr(p + 0x01C)); // 0245A6825448 0x1C Height                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
