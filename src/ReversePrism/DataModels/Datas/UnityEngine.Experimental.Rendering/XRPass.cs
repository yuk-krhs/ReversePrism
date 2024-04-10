using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Views                                  000185D1D988 ModelEnumListType List`1<XRView> List`1<XRView> List<XRView> Pointer
    // 018 M_OcclusionMesh                          000186584180 ModelClassType XROcclusionMesh XROcclusionMesh XROcclusionMesh Pointer
    // 020 CopyDepth                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 024 MultipassId                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 CullingPassId                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 RenderTarget                             000186655450 ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32
    // 058 RenderTargetDesc                         000186657320 ModelEnumType RenderTextureDescriptor RenderTextureDescriptor RenderTextureDescriptor Int32
    // 090 CullingParams                            000186660DB0 ModelEnumType ScriptableCullingParameters ScriptableCullingParameters ScriptableCullingParameters Int32
    // 6C0 <foveatedRenderingInfo>k__BackingField   <int> IL2CPP_TYPE_I
    public partial class XRPass : DataModel
    {
        public List<XRView>?                            M_Views                                 { get; set; }
        public XROcclusionMesh?                         M_OcclusionMesh                         { get; set; }
        public bool                                     CopyDepth                               { get; set; }
        public int                                      MultipassId                             { get; set; }
        public int                                      CullingPassId                           { get; set; }
        public RenderTargetIdentifier                   RenderTarget                            { get; set; }
        public RenderTextureDescriptor                  RenderTargetDesc                        { get; set; }
        public ScriptableCullingParameters              CullingParams                           { get; set; }

        public static XRPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XRPass() { Pointer= p0 };

            value.M_Views                                   = GetEnumList<XRView>(new IntPtr(p + 0x010)); // 0245A35D1240 0x10 M_Views                     ( 000185D1D988 ModelEnumListType List`1<XRView> List`1<XRView> List<XRView> Pointer )
            value.M_OcclusionMesh                           = GetObject<XROcclusionMesh>(new IntPtr(p + 0x018), ReversePrism.DataModels.XROcclusionMesh.FromPointer); // 0245A35D1260 0x18 M_OcclusionMesh             ( 000186584180 ModelClassType XROcclusionMesh XROcclusionMesh XROcclusionMesh Pointer )
            value.CopyDepth                                 = GetBool(new IntPtr(p + 0x020)); // 0245A35D1280 0x20 CopyDepth                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MultipassId                               = GetInt32(new IntPtr(p + 0x024)); // 0245A35D12A0 0x24 MultipassId                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CullingPassId                             = GetInt32(new IntPtr(p + 0x028)); // 0245A35D12C0 0x28 CullingPassId               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RenderTarget                              = (RenderTargetIdentifier)GetInt32(new IntPtr(p + 0x030)); // 0245A35D12E0 0x30 RenderTarget                ( 000186655450 ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32 )
            value.RenderTargetDesc                          = (RenderTextureDescriptor)GetInt32(new IntPtr(p + 0x058)); // 0245A35D1300 0x58 RenderTargetDesc            ( 000186657320 ModelEnumType RenderTextureDescriptor RenderTextureDescriptor RenderTextureDescriptor Int32 )
            value.CullingParams                             = (ScriptableCullingParameters)GetInt32(new IntPtr(p + 0x090)); // 0245A35D1320 0x90 CullingParams               ( 000186660DB0 ModelEnumType ScriptableCullingParameters ScriptableCullingParameters ScriptableCullingParameters Int32 )

            return value;
        }
    }
}
