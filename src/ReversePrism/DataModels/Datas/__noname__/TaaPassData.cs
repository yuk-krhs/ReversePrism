using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DstTex                                   ModelEnumType TextureHandle TextureHandle TextureHandle Int32
    // 018 SrcColorTex                              ModelEnumType TextureHandle TextureHandle TextureHandle Int32
    // 020 SrcDepthTex                              ModelEnumType TextureHandle TextureHandle TextureHandle Int32
    // 028 SrcMotionVectorTex                       ModelEnumType TextureHandle TextureHandle TextureHandle Int32
    // 030 SrcTaaAccumTex                           ModelEnumType TextureHandle TextureHandle TextureHandle Int32
    // 038 Material                                 ModelClassType Material Material Material Pointer
    // 040 PassIndex                                ModelPrimitiveType int int int Int32
    // 044 TaaFrameInfluence                        ModelPrimitiveType float float float Single
    // 048 TaaVarianceClampScale                    ModelPrimitiveType float float float Single
    // 050 TaaFilterWeights                         ModelPrimitiveListType float[] float[] List<float> Pointer
    public partial class TaaPassData : DataModel
    {
        public TextureHandle                            DstTex                                  { get; set; }
        public TextureHandle                            SrcColorTex                             { get; set; }
        public TextureHandle                            SrcDepthTex                             { get; set; }
        public TextureHandle                            SrcMotionVectorTex                      { get; set; }
        public TextureHandle                            SrcTaaAccumTex                          { get; set; }
        public Material?                                Material                                { get; set; }
        public int                                      PassIndex                               { get; set; }
        public float                                    TaaFrameInfluence                       { get; set; }
        public float                                    TaaVarianceClampScale                   { get; set; }
        public List<float>?                             TaaFilterWeights                        { get; set; }

        public static TaaPassData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TaaPassData() { Pointer= p0 };

            value.DstTex                                    = (TextureHandle)GetInt32(new IntPtr(p + 0x010)); // 0x10 DstTex                      ( ModelEnumType TextureHandle TextureHandle TextureHandle Int32 )
            value.SrcColorTex                               = (TextureHandle)GetInt32(new IntPtr(p + 0x018)); // 0x18 SrcColorTex                 ( ModelEnumType TextureHandle TextureHandle TextureHandle Int32 )
            value.SrcDepthTex                               = (TextureHandle)GetInt32(new IntPtr(p + 0x020)); // 0x20 SrcDepthTex                 ( ModelEnumType TextureHandle TextureHandle TextureHandle Int32 )
            value.SrcMotionVectorTex                        = (TextureHandle)GetInt32(new IntPtr(p + 0x028)); // 0x28 SrcMotionVectorTex          ( ModelEnumType TextureHandle TextureHandle TextureHandle Int32 )
            value.SrcTaaAccumTex                            = (TextureHandle)GetInt32(new IntPtr(p + 0x030)); // 0x30 SrcTaaAccumTex              ( ModelEnumType TextureHandle TextureHandle TextureHandle Int32 )
            value.Material                                  = GetObject<Material>(new IntPtr(p + 0x038), ReversePrism.DataModels.Material.FromPointer); // 0x38 Material                    ( ModelClassType Material Material Material Pointer )
            value.PassIndex                                 = GetInt32(new IntPtr(p + 0x040)); // 0x40 PassIndex                   ( ModelPrimitiveType int int int Int32 )
            value.TaaFrameInfluence                         = GetSingle(new IntPtr(p + 0x044)); // 0x44 TaaFrameInfluence           ( ModelPrimitiveType float float float Single )
            value.TaaVarianceClampScale                     = GetSingle(new IntPtr(p + 0x048)); // 0x48 TaaVarianceClampScale       ( ModelPrimitiveType float float float Single )
            value.TaaFilterWeights                          = GetSingleList(new IntPtr(p + 0x050)); // 0x50 TaaFilterWeights            ( ModelPrimitiveListType float[] float[] List<float> Pointer )

            return value;
        }
    }
}
