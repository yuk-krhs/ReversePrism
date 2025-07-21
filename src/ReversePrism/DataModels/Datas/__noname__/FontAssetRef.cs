using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NameHashCode                             ModelPrimitiveType int int int Int32
    // 014 FamilyNameHashCode                       ModelPrimitiveType int int int Int32
    // 018 StyleNameHashCode                        ModelPrimitiveType int int int Int32
    // 020 FamilyNameAndStyleHashCode               ModelPrimitiveType long long long Int64
    // 028 FontAsset                                ModelClassType FontAsset FontAsset FontAsset Pointer
    public partial class FontAssetRef : DataModel
    {
        public int                                      NameHashCode                            { get; set; }
        public int                                      FamilyNameHashCode                      { get; set; }
        public int                                      StyleNameHashCode                       { get; set; }
        public long                                     FamilyNameAndStyleHashCode              { get; set; }
        public FontAsset?                               FontAsset                               { get; set; }

        public static FontAssetRef? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FontAssetRef() { Pointer= p0 };

            value.NameHashCode                              = GetInt32(new IntPtr(p + 0x010)); // 0x10 NameHashCode                ( ModelPrimitiveType int int int Int32 )
            value.FamilyNameHashCode                        = GetInt32(new IntPtr(p + 0x014)); // 0x14 FamilyNameHashCode          ( ModelPrimitiveType int int int Int32 )
            value.StyleNameHashCode                         = GetInt32(new IntPtr(p + 0x018)); // 0x18 StyleNameHashCode           ( ModelPrimitiveType int int int Int32 )
            value.FamilyNameAndStyleHashCode                = GetInt64(new IntPtr(p + 0x020)); // 0x20 FamilyNameAndStyleHashCode  ( ModelPrimitiveType long long long Int64 )
            value.FontAsset                                 = GetObject<FontAsset>(new IntPtr(p + 0x028), ReversePrism.DataModels.FontAsset.FromPointer); // 0x28 FontAsset                   ( ModelClassType FontAsset FontAsset FontAsset Pointer )

            return value;
        }
    }
}
