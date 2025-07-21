using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_ShaderTagId                            ShaderTagId IL2CPP_TYPE_VALUETYPE
    // 0E0 Destination                              ModelClassType RTHandle RTHandle RTHandle Pointer
    // 0E8 DepthStencilFormat                       ModelEnumType GraphicsFormat GraphicsFormat GraphicsFormat Int32
    // 0EC ShaderTagId                              ModelEnumType ShaderTagId ShaderTagId ShaderTagId Int32
    // 0F0 M_PassData                               ModelClassType PassData PassData PassData Pointer
    // 0F8 M_FilteringSettings                      ModelEnumType FilteringSettings FilteringSettings FilteringSettings Int32
    public partial class DepthOnlyPass : DataModel
    {
        public RTHandle?                                Destination                             { get; set; }
        public GraphicsFormat                           DepthStencilFormat                      { get; set; }
        public ShaderTagId                              ShaderTagId                             { get; set; }
        public PassData?                                M_PassData                              { get; set; }
        public FilteringSettings                        M_FilteringSettings                     { get; set; }

        public static DepthOnlyPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DepthOnlyPass() { Pointer= p0 };

            value.Destination                               = GetObject<RTHandle>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.RTHandle.FromPointer); // 0xE0 Destination                 ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.DepthStencilFormat                        = (GraphicsFormat)GetInt32(new IntPtr(p + 0x0E8)); // 0xE8 DepthStencilFormat          ( ModelEnumType GraphicsFormat GraphicsFormat GraphicsFormat Int32 )
            value.ShaderTagId                               = (ShaderTagId)GetInt32(new IntPtr(p + 0x0EC)); // 0xEC ShaderTagId                 ( ModelEnumType ShaderTagId ShaderTagId ShaderTagId Int32 )
            value.M_PassData                                = GetObject<PassData>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.PassData.FromPointer); // 0xF0 M_PassData                  ( ModelClassType PassData PassData PassData Pointer )
            value.M_FilteringSettings                       = (FilteringSettings)GetInt32(new IntPtr(p + 0x0F8)); // 0xF8 M_FilteringSettings         ( ModelEnumType FilteringSettings FilteringSettings FilteringSettings Int32 )

            return value;
        }
    }
}
