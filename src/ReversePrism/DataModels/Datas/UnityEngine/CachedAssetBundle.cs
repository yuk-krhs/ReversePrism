using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Name                                   ModelPrimitiveType string string string String
    // 018 M_Hash                                   ModelEnumType Hash128 Hash128 Hash128 Int32
    public partial class CachedAssetBundle : DataModel
    {
        public string                                   M_Name                                  { get; set; }
        public Hash128                                  M_Hash                                  { get; set; }

        public static CachedAssetBundle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CachedAssetBundle() { Pointer= p0 };

            value.M_Name                                    = GetString(new IntPtr(p + 0x010)); // 0x10 M_Name                      ( ModelPrimitiveType string string string String )
            value.M_Hash                                    = (Hash128)GetInt32(new IntPtr(p + 0x018)); // 0x18 M_Hash                      ( ModelEnumType Hash128 Hash128 Hash128 Int32 )

            return value;
        }
    }
}
