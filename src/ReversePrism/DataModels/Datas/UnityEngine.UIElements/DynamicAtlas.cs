using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 m_Database                               Dictionary`2<Texture, TextureInfo> IL2CPP_TYPE_GENERICINST
    // 020 M_PointPage                              00018670F1F0 ModelClassType DynamicAtlasPage DynamicAtlasPage DynamicAtlasPage Pointer
    // 028 M_BilinearPage                           00018670F1F0 ModelClassType DynamicAtlasPage DynamicAtlasPage DynamicAtlasPage Pointer
    // 030 M_ColorSpace                             0001865D2B00 ModelEnumType ColorSpace ColorSpace ColorSpace Int32
    // 038 M_Panels                                 000185CE6868 ModelClassListType List`1<IPanel> List`1<IPanel> List<IPanel> Pointer
    // 040 M_MinAtlasSize                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 044 M_MaxAtlasSize                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 048 M_MaxSubTextureSize                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 04C M_ActiveFilters                          0001865C5750 ModelEnumType DynamicAtlasFilters DynamicAtlasFilters DynamicAtlasFilters Int32
    // 050 M_CustomFilter                           00018670ED30 ModelClassType DynamicAtlasCustomFilter DynamicAtlasCustomFilter DynamicAtlasCustomFilter Pointer
    public partial class DynamicAtlas
    {
        public DynamicAtlasPage?                        M_PointPage                             { get; set; }
        public DynamicAtlasPage?                        M_BilinearPage                          { get; set; }
        public ColorSpace                               M_ColorSpace                            { get; set; }
        public List<IPanel>?                            M_Panels                                { get; set; }
        public int                                      M_MinAtlasSize                          { get; set; }
        public int                                      M_MaxAtlasSize                          { get; set; }
        public int                                      M_MaxSubTextureSize                     { get; set; }
        public DynamicAtlasFilters                      M_ActiveFilters                         { get; set; }
        public DynamicAtlasCustomFilter?                M_CustomFilter                          { get; set; }

        public static DynamicAtlas? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DynamicAtlas();

            value.M_PointPage                               = GetObject<DynamicAtlasPage>(new IntPtr(p + 0x020), ReversePrism.DataModels.DynamicAtlasPage.FromPointer); // 0270066E07C8 0x20 M_PointPage                 ( 00018670F1F0 ModelClassType DynamicAtlasPage DynamicAtlasPage DynamicAtlasPage Pointer )
            value.M_BilinearPage                            = GetObject<DynamicAtlasPage>(new IntPtr(p + 0x028), ReversePrism.DataModels.DynamicAtlasPage.FromPointer); // 0270066E07E8 0x28 M_BilinearPage              ( 00018670F1F0 ModelClassType DynamicAtlasPage DynamicAtlasPage DynamicAtlasPage Pointer )
            value.M_ColorSpace                              = (ColorSpace)GetInt32(new IntPtr(p + 0x030)); // 0270066E0808 0x30 M_ColorSpace                ( 0001865D2B00 ModelEnumType ColorSpace ColorSpace ColorSpace Int32 )
            value.M_Panels                                  = GetObjectList<IPanel>(new IntPtr(p + 0x038), ReversePrism.DataModels.IPanel.FromPointer); // 0270066E0828 0x38 M_Panels                    ( 000185CE6868 ModelClassListType List`1<IPanel> List`1<IPanel> List<IPanel> Pointer )
            value.M_MinAtlasSize                            = GetInt32(new IntPtr(p + 0x040)); // 0270066E0848 0x40 M_MinAtlasSize              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_MaxAtlasSize                            = GetInt32(new IntPtr(p + 0x044)); // 0270066E0868 0x44 M_MaxAtlasSize              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_MaxSubTextureSize                       = GetInt32(new IntPtr(p + 0x048)); // 0270066E0888 0x48 M_MaxSubTextureSize         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_ActiveFilters                           = (DynamicAtlasFilters)GetInt32(new IntPtr(p + 0x04C)); // 0270066E08A8 0x4C M_ActiveFilters             ( 0001865C5750 ModelEnumType DynamicAtlasFilters DynamicAtlasFilters DynamicAtlasFilters Int32 )
            value.M_CustomFilter                            = GetObject<DynamicAtlasCustomFilter>(new IntPtr(p + 0x050), ReversePrism.DataModels.DynamicAtlasCustomFilter.FromPointer); // 0270066E08C8 0x50 M_CustomFilter              ( 00018670ED30 ModelClassType DynamicAtlasCustomFilter DynamicAtlasCustomFilter DynamicAtlasCustomFilter Pointer )

            return value;
        }
    }
}
