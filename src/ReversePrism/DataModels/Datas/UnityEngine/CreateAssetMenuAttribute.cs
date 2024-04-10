using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MenuName                                 000186671910 ModelPrimitiveType string string string String
    // 018 FileName                                 000186671910 ModelPrimitiveType string string string String
    // 020 Order                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class CreateAssetMenuAttribute : DataModel
    {
        public string                                   MenuName                                { get; set; }
        public string                                   FileName                                { get; set; }
        public int                                      Order                                   { get; set; }

        public static CreateAssetMenuAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CreateAssetMenuAttribute() { Pointer= p0 };

            value.MenuName                                  = GetString(new IntPtr(p + 0x010)); // 0245A687B498 0x10 MenuName                    ( 000186671910 ModelPrimitiveType string string string String )
            value.FileName                                  = GetString(new IntPtr(p + 0x018)); // 0245A687B4B8 0x18 FileName                    ( 000186671910 ModelPrimitiveType string string string String )
            value.Order                                     = GetInt32(new IntPtr(p + 0x020)); // 0245A687B4D8 0x20 Order                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
