using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Path                                     ModelPrimitiveType string string string String
    // 018 TypeFullName                             ModelPrimitiveType string string string String
    // 020 Asset                                    ModelClassType Object Object Object Pointer
    // 028 M_CachedType                             ModelClassType Type Type Type Pointer
    public partial class AssetEntry : DataModel
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
            var value   = new AssetEntry() { Pointer= p0 };

            value.Path                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Path                        ( ModelPrimitiveType string string string String )
            value.TypeFullName                              = GetString(new IntPtr(p + 0x018)); // 0x18 TypeFullName                ( ModelPrimitiveType string string string String )
            value.Asset                                     = GetObject<Object>(new IntPtr(p + 0x020), ReversePrism.DataModels.Object.FromPointer); // 0x20 Asset                       ( ModelClassType Object Object Object Pointer )
            value.M_CachedType                              = GetObject<Type>(new IntPtr(p + 0x028), ReversePrism.DataModels.Type.FromPointer); // 0x28 M_CachedType                ( ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
