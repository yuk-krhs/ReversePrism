using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_MinAtlasSize                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 M_MaxAtlasSize                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 M_MaxSubTextureSize                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C M_ActiveFilters                          0001865C5750 ModelEnumType DynamicAtlasFilters DynamicAtlasFilters DynamicAtlasFilters Int32
    // 020 M_CustomFilter                           00018670ED30 ModelClassType DynamicAtlasCustomFilter DynamicAtlasCustomFilter DynamicAtlasCustomFilter Pointer
    public partial class DynamicAtlasSettings
    {
        public int                                      M_MinAtlasSize                          { get; set; }
        public int                                      M_MaxAtlasSize                          { get; set; }
        public int                                      M_MaxSubTextureSize                     { get; set; }
        public DynamicAtlasFilters                      M_ActiveFilters                         { get; set; }
        public DynamicAtlasCustomFilter?                M_CustomFilter                          { get; set; }

        public static DynamicAtlasSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DynamicAtlasSettings();

            value.M_MinAtlasSize                            = GetInt32(new IntPtr(p + 0x010)); // 0270067DB538 0x10 M_MinAtlasSize              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_MaxAtlasSize                            = GetInt32(new IntPtr(p + 0x014)); // 0270067DB558 0x14 M_MaxAtlasSize              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_MaxSubTextureSize                       = GetInt32(new IntPtr(p + 0x018)); // 0270067DB578 0x18 M_MaxSubTextureSize         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_ActiveFilters                           = (DynamicAtlasFilters)GetInt32(new IntPtr(p + 0x01C)); // 0270067DB598 0x1C M_ActiveFilters             ( 0001865C5750 ModelEnumType DynamicAtlasFilters DynamicAtlasFilters DynamicAtlasFilters Int32 )
            value.M_CustomFilter                            = GetObject<DynamicAtlasCustomFilter>(new IntPtr(p + 0x020), ReversePrism.DataModels.DynamicAtlasCustomFilter.FromPointer); // 0270067DB5B8 0x20 M_CustomFilter              ( 00018670ED30 ModelClassType DynamicAtlasCustomFilter DynamicAtlasCustomFilter DynamicAtlasCustomFilter Pointer )

            return value;
        }
    }
}
