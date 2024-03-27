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
    // 010 BlitMaterial                             00018660BDD0 ModelClassType Material Material Material Pointer
    // 018 BlurMaterial                             00018660BDD0 ModelClassType Material Material Material Pointer
    // 020 TintColor                                0001865AA8E0 ModelEnumType Color Color Color Int32
    // 030 Iterations                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 034 TmpRTId                                  0001865F4260 ModelPrimitiveType int int int Int32
    // 038 BlurOffsetId                             0001865F4260 ModelPrimitiveType int int int Int32
    // 03C TintColorId                              0001865F4260 ModelPrimitiveType int int int Int32
    // 040 Pyramid                                  000185CBE5E8 ModelEnumListType Level[] Level[] List<Level> Pointer
    // 000 MaxPyramidSize                           int IL2CPP_TYPE_I4
    public partial class KawaseBlurPass
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
            var value   = new KawaseBlurPass();

            value.BlitMaterial                              = GetObject<Material>(new IntPtr(p + 0x010), ReversePrism.DataModels.Material.FromPointer); // 0270DBA7C308 0x10 BlitMaterial                ( 00018660BDD0 ModelClassType Material Material Material Pointer )
            value.BlurMaterial                              = GetObject<Material>(new IntPtr(p + 0x018), ReversePrism.DataModels.Material.FromPointer); // 0270DBA7C328 0x18 BlurMaterial                ( 00018660BDD0 ModelClassType Material Material Material Pointer )
            value.TintColor                                 = (Color)GetInt32(new IntPtr(p + 0x020)); // 0270DBA7C348 0x20 TintColor                   ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.Iterations                                = GetInt32(new IntPtr(p + 0x030)); // 0270DBA7C368 0x30 Iterations                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TmpRTId                                   = GetInt32(new IntPtr(p + 0x034)); // 0270DBA7C388 0x34 TmpRTId                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.BlurOffsetId                              = GetInt32(new IntPtr(p + 0x038)); // 0270DBA7C3A8 0x38 BlurOffsetId                ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.TintColorId                               = GetInt32(new IntPtr(p + 0x03C)); // 0270DBA7C3C8 0x3C TintColorId                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Pyramid                                   = GetEnumList<Level>(new IntPtr(p + 0x040)); // 0270DBA7C3E8 0x40 Pyramid                     ( 000185CBE5E8 ModelEnumListType Level[] Level[] List<Level> Pointer )

            return value;
        }
    }
}
