using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TexL0_L1rx                               00018664D240 ModelClassType Texture Texture Texture Pointer
    // 018 TexL1_G_ry                               00018664D240 ModelClassType Texture Texture Texture Pointer
    // 020 TexL1_B_rz                               00018664D240 ModelClassType Texture Texture Texture Pointer
    // 028 TexL2_0                                  00018664D240 ModelClassType Texture Texture Texture Pointer
    // 030 TexL2_1                                  00018664D240 ModelClassType Texture Texture Texture Pointer
    // 038 TexL2_2                                  00018664D240 ModelClassType Texture Texture Texture Pointer
    // 040 TexL2_3                                  00018664D240 ModelClassType Texture Texture Texture Pointer
    // 048 TexValidity                              00018664ECA0 ModelClassType Texture3D Texture3D Texture3D Pointer
    // 050 Width                                    0001865F2F90 ModelPrimitiveType int int int Int32
    // 054 Height                                   0001865F2F90 ModelPrimitiveType int int int Int32
    // 058 Depth                                    0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class DataLocation : DataModel
    {
        public Texture?                                 TexL0_L1rx                              { get; set; }
        public Texture?                                 TexL1_G_ry                              { get; set; }
        public Texture?                                 TexL1_B_rz                              { get; set; }
        public Texture?                                 TexL2_0                                 { get; set; }
        public Texture?                                 TexL2_1                                 { get; set; }
        public Texture?                                 TexL2_2                                 { get; set; }
        public Texture?                                 TexL2_3                                 { get; set; }
        public Texture3D?                               TexValidity                             { get; set; }
        public int                                      Width                                   { get; set; }
        public int                                      Height                                  { get; set; }
        public int                                      Depth                                   { get; set; }

        public static DataLocation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataLocation() { Pointer= p0 };

            value.TexL0_L1rx                                = GetObject<Texture>(new IntPtr(p + 0x010), ReversePrism.DataModels.Texture.FromPointer); // 02466920D4D8 0x10 TexL0_L1rx                  ( 00018664D240 ModelClassType Texture Texture Texture Pointer )
            value.TexL1_G_ry                                = GetObject<Texture>(new IntPtr(p + 0x018), ReversePrism.DataModels.Texture.FromPointer); // 02466920D4F8 0x18 TexL1_G_ry                  ( 00018664D240 ModelClassType Texture Texture Texture Pointer )
            value.TexL1_B_rz                                = GetObject<Texture>(new IntPtr(p + 0x020), ReversePrism.DataModels.Texture.FromPointer); // 02466920D518 0x20 TexL1_B_rz                  ( 00018664D240 ModelClassType Texture Texture Texture Pointer )
            value.TexL2_0                                   = GetObject<Texture>(new IntPtr(p + 0x028), ReversePrism.DataModels.Texture.FromPointer); // 02466920D538 0x28 TexL2_0                     ( 00018664D240 ModelClassType Texture Texture Texture Pointer )
            value.TexL2_1                                   = GetObject<Texture>(new IntPtr(p + 0x030), ReversePrism.DataModels.Texture.FromPointer); // 02466920D558 0x30 TexL2_1                     ( 00018664D240 ModelClassType Texture Texture Texture Pointer )
            value.TexL2_2                                   = GetObject<Texture>(new IntPtr(p + 0x038), ReversePrism.DataModels.Texture.FromPointer); // 02466920D578 0x38 TexL2_2                     ( 00018664D240 ModelClassType Texture Texture Texture Pointer )
            value.TexL2_3                                   = GetObject<Texture>(new IntPtr(p + 0x040), ReversePrism.DataModels.Texture.FromPointer); // 02466920D598 0x40 TexL2_3                     ( 00018664D240 ModelClassType Texture Texture Texture Pointer )
            value.TexValidity                               = GetObject<Texture3D>(new IntPtr(p + 0x048), ReversePrism.DataModels.Texture3D.FromPointer); // 02466920D5B8 0x48 TexValidity                 ( 00018664ECA0 ModelClassType Texture3D Texture3D Texture3D Pointer )
            value.Width                                     = GetInt32(new IntPtr(p + 0x050)); // 02466920D5D8 0x50 Width                       ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Height                                    = GetInt32(new IntPtr(p + 0x054)); // 02466920D5F8 0x54 Height                      ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Depth                                     = GetInt32(new IntPtr(p + 0x058)); // 02466920D618 0x58 Depth                       ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
