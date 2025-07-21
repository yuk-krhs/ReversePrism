using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0E0 M_LutBuilderLdr                          ModelClassType Material Material Material Pointer
    // 0E8 M_LutBuilderHdr                          ModelClassType Material Material Material Pointer
    // 0F0 M_HdrLutFormat                           ModelEnumType GraphicsFormat GraphicsFormat GraphicsFormat Int32
    // 0F4 M_LdrLutFormat                           ModelEnumType GraphicsFormat GraphicsFormat GraphicsFormat Int32
    // 0F8 M_PassData                               ModelClassType PassData PassData PassData Pointer
    // 100 M_InternalLut                            ModelClassType RTHandle RTHandle RTHandle Pointer
    // 108 M_AllowColorGradingACESHDR               ModelPrimitiveType bool bool bool Bool
    public partial class ColorGradingLutPass : DataModel
    {
        public Material?                                M_LutBuilderLdr                         { get; set; }
        public Material?                                M_LutBuilderHdr                         { get; set; }
        public GraphicsFormat                           M_HdrLutFormat                          { get; set; }
        public GraphicsFormat                           M_LdrLutFormat                          { get; set; }
        public PassData?                                M_PassData                              { get; set; }
        public RTHandle?                                M_InternalLut                           { get; set; }
        public bool                                     M_AllowColorGradingACESHDR              { get; set; }

        public static ColorGradingLutPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColorGradingLutPass() { Pointer= p0 };

            value.M_LutBuilderLdr                           = GetObject<Material>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.Material.FromPointer); // 0xE0 M_LutBuilderLdr             ( ModelClassType Material Material Material Pointer )
            value.M_LutBuilderHdr                           = GetObject<Material>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.Material.FromPointer); // 0xE8 M_LutBuilderHdr             ( ModelClassType Material Material Material Pointer )
            value.M_HdrLutFormat                            = (GraphicsFormat)GetInt32(new IntPtr(p + 0x0F0)); // 0xF0 M_HdrLutFormat              ( ModelEnumType GraphicsFormat GraphicsFormat GraphicsFormat Int32 )
            value.M_LdrLutFormat                            = (GraphicsFormat)GetInt32(new IntPtr(p + 0x0F4)); // 0xF4 M_LdrLutFormat              ( ModelEnumType GraphicsFormat GraphicsFormat GraphicsFormat Int32 )
            value.M_PassData                                = GetObject<PassData>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.PassData.FromPointer); // 0xF8 M_PassData                  ( ModelClassType PassData PassData PassData Pointer )
            value.M_InternalLut                             = GetObject<RTHandle>(new IntPtr(p + 0x100), ReversePrism.DataModels.RTHandle.FromPointer); // 0x100 M_InternalLut               ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_AllowColorGradingACESHDR                = GetBool(new IntPtr(p + 0x108)); // 0x108 M_AllowColorGradingACESHDR  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
