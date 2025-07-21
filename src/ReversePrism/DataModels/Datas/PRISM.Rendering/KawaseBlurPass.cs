using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 profileTag                               string IL2CPP_TYPE_STRING
    // 008 profileSampler                           ProfileSampler IL2CPP_TYPE_CLASS
    // 010 BlitMaterial                             ModelClassType Material Material Material Pointer
    // 018 BlurMaterial                             ModelClassType Material Material Material Pointer
    // 020 TintColor                                ModelEnumType Color Color Color Int32
    // 030 Iterations                               ModelPrimitiveType int int int Int32
    // 034 TmpRTId                                  ModelPrimitiveType int int int Int32
    // 038 BlurOffsetId                             ModelPrimitiveType int int int Int32
    // 03C TintColorId                              ModelPrimitiveType int int int Int32
    // 040 Pyramid                                  ModelEnumListType Level[] Level[] List<Level> Pointer
    // 000 MaxPyramidSize                           int IL2CPP_TYPE_I4
    public partial class KawaseBlurPass : DataModel
    {
        public Material?                                BlitMaterial                            { get; set; }
        public Material?                                BlurMaterial                            { get; set; }
        public Color                                    TintColor                               { get; set; }
        public int                                      Iterations                              { get; set; }
        public int                                      TmpRTId                                 { get; set; }
        public int                                      BlurOffsetId                            { get; set; }
        public int                                      TintColorId                             { get; set; }
        public List<Level>?                             Pyramid                                 { get; set; }

        public static KawaseBlurPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new KawaseBlurPass() { Pointer= p0 };

            value.BlitMaterial                              = GetObject<Material>(new IntPtr(p + 0x010), ReversePrism.DataModels.Material.FromPointer); // 0x10 BlitMaterial                ( ModelClassType Material Material Material Pointer )
            value.BlurMaterial                              = GetObject<Material>(new IntPtr(p + 0x018), ReversePrism.DataModels.Material.FromPointer); // 0x18 BlurMaterial                ( ModelClassType Material Material Material Pointer )
            value.TintColor                                 = (Color)GetInt32(new IntPtr(p + 0x020)); // 0x20 TintColor                   ( ModelEnumType Color Color Color Int32 )
            value.Iterations                                = GetInt32(new IntPtr(p + 0x030)); // 0x30 Iterations                  ( ModelPrimitiveType int int int Int32 )
            value.TmpRTId                                   = GetInt32(new IntPtr(p + 0x034)); // 0x34 TmpRTId                     ( ModelPrimitiveType int int int Int32 )
            value.BlurOffsetId                              = GetInt32(new IntPtr(p + 0x038)); // 0x38 BlurOffsetId                ( ModelPrimitiveType int int int Int32 )
            value.TintColorId                               = GetInt32(new IntPtr(p + 0x03C)); // 0x3C TintColorId                 ( ModelPrimitiveType int int int Int32 )
            value.Pyramid                                   = GetEnumList<Level>(new IntPtr(p + 0x040)); // 0x40 Pyramid                     ( ModelEnumListType Level[] Level[] List<Level> Pointer )

            return value;
        }
    }
}
