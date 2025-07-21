using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsEnum                                   ModelPrimitiveType bool bool bool Bool
    // 011 StoreAsText                              ModelPrimitiveType bool bool bool Bool
    // 018 <EnumValues>k__BackingField              Dictionary`2<int, string> IL2CPP_TYPE_GENERICINST
    public partial class EnumCacheInfo : DataModel
    {
        public bool                                     IsEnum                                  { get; set; }
        public bool                                     StoreAsText                             { get; set; }

        public static EnumCacheInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnumCacheInfo() { Pointer= p0 };

            value.IsEnum                                    = GetBool(new IntPtr(p + 0x010)); // 0x10 IsEnum                      ( ModelPrimitiveType bool bool bool Bool )
            value.StoreAsText                               = GetBool(new IntPtr(p + 0x011)); // 0x11 StoreAsText                 ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
