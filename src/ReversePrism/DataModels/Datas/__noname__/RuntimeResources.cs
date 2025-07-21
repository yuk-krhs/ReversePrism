using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Index                                    ModelClassType ComputeBuffer ComputeBuffer ComputeBuffer Pointer
    // 018 CellIndices                              ModelClassType ComputeBuffer ComputeBuffer ComputeBuffer Pointer
    // 020 L0_L1rx                                  ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 028 L1_G_ry                                  ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 030 L1_B_rz                                  ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 038 L2_0                                     ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 040 L2_1                                     ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 048 L2_2                                     ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 050 L2_3                                     ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 058 Validity                                 ModelClassType Texture3D Texture3D Texture3D Pointer
    public partial class RuntimeResources : DataModel
    {
        public ComputeBuffer?                           Index                                   { get; set; }
        public ComputeBuffer?                           CellIndices                             { get; set; }
        public RenderTexture?                           L0_L1rx                                 { get; set; }
        public RenderTexture?                           L1_G_ry                                 { get; set; }
        public RenderTexture?                           L1_B_rz                                 { get; set; }
        public RenderTexture?                           L2_0                                    { get; set; }
        public RenderTexture?                           L2_1                                    { get; set; }
        public RenderTexture?                           L2_2                                    { get; set; }
        public RenderTexture?                           L2_3                                    { get; set; }
        public Texture3D?                               Validity                                { get; set; }

        public static RuntimeResources? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RuntimeResources() { Pointer= p0 };

            value.Index                                     = GetObject<ComputeBuffer>(new IntPtr(p + 0x010), ReversePrism.DataModels.ComputeBuffer.FromPointer); // 0x10 Index                       ( ModelClassType ComputeBuffer ComputeBuffer ComputeBuffer Pointer )
            value.CellIndices                               = GetObject<ComputeBuffer>(new IntPtr(p + 0x018), ReversePrism.DataModels.ComputeBuffer.FromPointer); // 0x18 CellIndices                 ( ModelClassType ComputeBuffer ComputeBuffer ComputeBuffer Pointer )
            value.L0_L1rx                                   = GetObject<RenderTexture>(new IntPtr(p + 0x020), ReversePrism.DataModels.RenderTexture.FromPointer); // 0x20 L0_L1rx                     ( ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.L1_G_ry                                   = GetObject<RenderTexture>(new IntPtr(p + 0x028), ReversePrism.DataModels.RenderTexture.FromPointer); // 0x28 L1_G_ry                     ( ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.L1_B_rz                                   = GetObject<RenderTexture>(new IntPtr(p + 0x030), ReversePrism.DataModels.RenderTexture.FromPointer); // 0x30 L1_B_rz                     ( ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.L2_0                                      = GetObject<RenderTexture>(new IntPtr(p + 0x038), ReversePrism.DataModels.RenderTexture.FromPointer); // 0x38 L2_0                        ( ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.L2_1                                      = GetObject<RenderTexture>(new IntPtr(p + 0x040), ReversePrism.DataModels.RenderTexture.FromPointer); // 0x40 L2_1                        ( ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.L2_2                                      = GetObject<RenderTexture>(new IntPtr(p + 0x048), ReversePrism.DataModels.RenderTexture.FromPointer); // 0x48 L2_2                        ( ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.L2_3                                      = GetObject<RenderTexture>(new IntPtr(p + 0x050), ReversePrism.DataModels.RenderTexture.FromPointer); // 0x50 L2_3                        ( ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.Validity                                  = GetObject<Texture3D>(new IntPtr(p + 0x058), ReversePrism.DataModels.Texture3D.FromPointer); // 0x58 Validity                    ( ModelClassType Texture3D Texture3D Texture3D Pointer )

            return value;
        }
    }
}
