using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0E0 M_SampleOffsetShaderHandle               ModelPrimitiveType int int int Int32
    // 0E8 M_SamplingMaterial                       ModelClassType Material Material Material Pointer
    // 0F0 M_DownsamplingMethod                     ModelEnumType Downsampling Downsampling Downsampling Int32
    // 0F8 M_CopyColorMaterial                      ModelClassType Material Material Material Pointer
    // 100 Source                                   ModelClassType RTHandle RTHandle RTHandle Pointer
    // 108 Destination                              ModelClassType RTHandle RTHandle RTHandle Pointer
    // 110 DestinationID                            ModelPrimitiveType int int int Int32
    // 118 M_PassData                               ModelClassType PassData PassData PassData Pointer
    public partial class CopyColorPass : DataModel
    {
        public int                                      M_SampleOffsetShaderHandle              { get; set; }
        public Material?                                M_SamplingMaterial                      { get; set; }
        public Downsampling                             M_DownsamplingMethod                    { get; set; }
        public Material?                                M_CopyColorMaterial                     { get; set; }
        public RTHandle?                                Source                                  { get; set; }
        public RTHandle?                                Destination                             { get; set; }
        public int                                      DestinationID                           { get; set; }
        public PassData?                                M_PassData                              { get; set; }

        public static CopyColorPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CopyColorPass() { Pointer= p0 };

            value.M_SampleOffsetShaderHandle                = GetInt32(new IntPtr(p + 0x0E0)); // 0xE0 M_SampleOffsetShaderHandle  ( ModelPrimitiveType int int int Int32 )
            value.M_SamplingMaterial                        = GetObject<Material>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.Material.FromPointer); // 0xE8 M_SamplingMaterial          ( ModelClassType Material Material Material Pointer )
            value.M_DownsamplingMethod                      = (Downsampling)GetInt32(new IntPtr(p + 0x0F0)); // 0xF0 M_DownsamplingMethod        ( ModelEnumType Downsampling Downsampling Downsampling Int32 )
            value.M_CopyColorMaterial                       = GetObject<Material>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.Material.FromPointer); // 0xF8 M_CopyColorMaterial         ( ModelClassType Material Material Material Pointer )
            value.Source                                    = GetObject<RTHandle>(new IntPtr(p + 0x100), ReversePrism.DataModels.RTHandle.FromPointer); // 0x100 Source                      ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.Destination                               = GetObject<RTHandle>(new IntPtr(p + 0x108), ReversePrism.DataModels.RTHandle.FromPointer); // 0x108 Destination                 ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.DestinationID                             = GetInt32(new IntPtr(p + 0x110)); // 0x110 DestinationID               ( ModelPrimitiveType int int int Int32 )
            value.M_PassData                                = GetObject<PassData>(new IntPtr(p + 0x118), ReversePrism.DataModels.PassData.FromPointer); // 0x118 M_PassData                  ( ModelClassType PassData PassData PassData Pointer )

            return value;
        }
    }
}
