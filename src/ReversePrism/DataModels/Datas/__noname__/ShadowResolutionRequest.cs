using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 VisibleLightIndex                        ModelPrimitiveType int int int Int32
    // 014 PerLightShadowSliceIndex                 ModelPrimitiveType int int int Int32
    // 018 RequestedResolution                      ModelPrimitiveType int int int Int32
    // 01C SoftShadow                               ModelPrimitiveType bool bool bool Bool
    // 01D PointLightShadow                         ModelPrimitiveType bool bool bool Bool
    // 020 OffsetX                                  ModelPrimitiveType int int int Int32
    // 024 OffsetY                                  ModelPrimitiveType int int int Int32
    // 028 AllocatedResolution                      ModelPrimitiveType int int int Int32
    public partial class ShadowResolutionRequest : DataModel
    {
        public int                                      VisibleLightIndex                       { get; set; }
        public int                                      PerLightShadowSliceIndex                { get; set; }
        public int                                      RequestedResolution                     { get; set; }
        public bool                                     SoftShadow                              { get; set; }
        public bool                                     PointLightShadow                        { get; set; }
        public int                                      OffsetX                                 { get; set; }
        public int                                      OffsetY                                 { get; set; }
        public int                                      AllocatedResolution                     { get; set; }

        public static ShadowResolutionRequest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShadowResolutionRequest() { Pointer= p0 };

            value.VisibleLightIndex                         = GetInt32(new IntPtr(p + 0x010)); // 0x10 VisibleLightIndex           ( ModelPrimitiveType int int int Int32 )
            value.PerLightShadowSliceIndex                  = GetInt32(new IntPtr(p + 0x014)); // 0x14 PerLightShadowSliceIndex    ( ModelPrimitiveType int int int Int32 )
            value.RequestedResolution                       = GetInt32(new IntPtr(p + 0x018)); // 0x18 RequestedResolution         ( ModelPrimitiveType int int int Int32 )
            value.SoftShadow                                = GetBool(new IntPtr(p + 0x01C)); // 0x1C SoftShadow                  ( ModelPrimitiveType bool bool bool Bool )
            value.PointLightShadow                          = GetBool(new IntPtr(p + 0x01D)); // 0x1D PointLightShadow            ( ModelPrimitiveType bool bool bool Bool )
            value.OffsetX                                   = GetInt32(new IntPtr(p + 0x020)); // 0x20 OffsetX                     ( ModelPrimitiveType int int int Int32 )
            value.OffsetY                                   = GetInt32(new IntPtr(p + 0x024)); // 0x24 OffsetY                     ( ModelPrimitiveType int int int Int32 )
            value.AllocatedResolution                       = GetInt32(new IntPtr(p + 0x028)); // 0x28 AllocatedResolution         ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
