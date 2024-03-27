using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FallbackID                               0001865F7E40 ModelPrimitiveType long long long Int64
    // 018 SourceMaterial                           00018660C4B0 ModelClassType Material Material Material Pointer
    // 020 SourceMaterialCRC                        0001865F2F90 ModelPrimitiveType int int int Int32
    // 028 _FallbackMaterial                        00018660C4B0 ModelClassType Material Material Material Pointer
    // 030 Count                                    0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class FallbackMaterial
    {
        public long                                     FallbackID                              { get; set; }
        public Material?                                SourceMaterial                          { get; set; }
        public int                                      SourceMaterialCRC                       { get; set; }
        public Material?                                _FallbackMaterial                       { get; set; }
        public int                                      Count                                   { get; set; }

        public static FallbackMaterial? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FallbackMaterial();

            value.FallbackID                                = GetInt64(new IntPtr(p + 0x010)); // 0270043041B0 0x10 FallbackID                  ( 0001865F7E40 ModelPrimitiveType long long long Int64 )
            value.SourceMaterial                            = GetObject<Material>(new IntPtr(p + 0x018), ReversePrism.DataModels.Material.FromPointer); // 0270043041D0 0x18 SourceMaterial              ( 00018660C4B0 ModelClassType Material Material Material Pointer )
            value.SourceMaterialCRC                         = GetInt32(new IntPtr(p + 0x020)); // 0270043041F0 0x20 SourceMaterialCRC           ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value._FallbackMaterial                         = GetObject<Material>(new IntPtr(p + 0x028), ReversePrism.DataModels.Material.FromPointer); // 027004304210 0x28 _FallbackMaterial           ( 00018660C4B0 ModelClassType Material Material Material Pointer )
            value.Count                                     = GetInt32(new IntPtr(p + 0x030)); // 027004304230 0x30 Count                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
