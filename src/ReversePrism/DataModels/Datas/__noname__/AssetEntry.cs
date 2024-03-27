using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Path                                     0001866722E0 ModelPrimitiveType string string string String
    // 018 TypeFullName                             0001866722E0 ModelPrimitiveType string string string String
    // 020 Asset                                    0001866386D0 ModelClassType Object Object Object Pointer
    // 028 M_CachedType                             000186692850 ModelClassType Type Type Type Pointer
    public partial class AssetEntry
    {
        public string                                   Path                                    { get; set; }
        public string                                   TypeFullName                            { get; set; }
        public Object?                                  Asset                                   { get; set; }
        public Type?                                    M_CachedType                            { get; set; }

        public static AssetEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AssetEntry();

            value.Path                                      = GetString(new IntPtr(p + 0x010)); // 027006854378 0x10 Path                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.TypeFullName                              = GetString(new IntPtr(p + 0x018)); // 027006854398 0x18 TypeFullName                ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Asset                                     = GetObject<Object>(new IntPtr(p + 0x020), ReversePrism.DataModels.Object.FromPointer); // 0270068543B8 0x20 Asset                       ( 0001866386D0 ModelClassType Object Object Object Pointer )
            value.M_CachedType                              = GetObject<Type>(new IntPtr(p + 0x028), ReversePrism.DataModels.Type.FromPointer); // 0270068543D8 0x28 M_CachedType                ( 000186692850 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
