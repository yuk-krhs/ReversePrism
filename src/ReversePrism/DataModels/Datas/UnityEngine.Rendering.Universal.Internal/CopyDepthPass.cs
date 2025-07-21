using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0E0 Source                                   ModelClassType RTHandle RTHandle RTHandle Pointer
    // 0E8 Destination                              ModelClassType RTHandle RTHandle RTHandle Pointer
    // 0F0 MssaSamples                              ModelPrimitiveType int int int Int32
    // 0F4 CopyToDepth                              ModelPrimitiveType bool bool bool Bool
    // 0F8 M_CopyDepthMaterial                      ModelClassType Material Material Material Pointer
    // 100 M_CopyResolvedDepth                      ModelPrimitiveType bool bool bool Bool
    // 101 M_ShouldClear                            ModelPrimitiveType bool bool bool Bool
    // 108 M_PassData                               ModelClassType PassData PassData PassData Pointer
    public partial class CopyDepthPass : DataModel
    {
        public RTHandle?                                Source                                  { get; set; }
        public RTHandle?                                Destination                             { get; set; }
        public int                                      MssaSamples                             { get; set; }
        public bool                                     CopyToDepth                             { get; set; }
        public Material?                                M_CopyDepthMaterial                     { get; set; }
        public bool                                     M_CopyResolvedDepth                     { get; set; }
        public bool                                     M_ShouldClear                           { get; set; }
        public PassData?                                M_PassData                              { get; set; }

        public static CopyDepthPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CopyDepthPass() { Pointer= p0 };

            value.Source                                    = GetObject<RTHandle>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.RTHandle.FromPointer); // 0xE0 Source                      ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.Destination                               = GetObject<RTHandle>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.RTHandle.FromPointer); // 0xE8 Destination                 ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.MssaSamples                               = GetInt32(new IntPtr(p + 0x0F0)); // 0xF0 MssaSamples                 ( ModelPrimitiveType int int int Int32 )
            value.CopyToDepth                               = GetBool(new IntPtr(p + 0x0F4)); // 0xF4 CopyToDepth                 ( ModelPrimitiveType bool bool bool Bool )
            value.M_CopyDepthMaterial                       = GetObject<Material>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.Material.FromPointer); // 0xF8 M_CopyDepthMaterial         ( ModelClassType Material Material Material Pointer )
            value.M_CopyResolvedDepth                       = GetBool(new IntPtr(p + 0x100)); // 0x100 M_CopyResolvedDepth         ( ModelPrimitiveType bool bool bool Bool )
            value.M_ShouldClear                             = GetBool(new IntPtr(p + 0x101)); // 0x101 M_ShouldClear               ( ModelPrimitiveType bool bool bool Bool )
            value.M_PassData                                = GetObject<PassData>(new IntPtr(p + 0x108), ReversePrism.DataModels.PassData.FromPointer); // 0x108 M_PassData                  ( ModelClassType PassData PassData PassData Pointer )

            return value;
        }
    }
}
