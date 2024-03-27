using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ActionPatternId                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 Score                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 ComboDataList                            000185CCC248 ModelClassListType List`1<AiComboData> List`1<AiComboData> List<AiComboData> Pointer
    public partial class AiPatternData
    {
        public int                                      ActionPatternId                         { get; set; }
        public int                                      Score                                   { get; set; }
        public List<AiComboData>?                       ComboDataList                           { get; set; }

        public static AiPatternData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AiPatternData();

            value.ActionPatternId                           = GetInt32(new IntPtr(p + 0x010)); // 0270D5A6F128 0x10 ActionPatternId             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Score                                     = GetInt32(new IntPtr(p + 0x014)); // 0270D5A6F148 0x14 Score                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ComboDataList                             = GetObjectList<AiComboData>(new IntPtr(p + 0x018), ReversePrism.DataModels.AiComboData.FromPointer); // 0270D5A6F168 0x18 ComboDataList               ( 000185CCC248 ModelClassListType List`1<AiComboData> List`1<AiComboData> List<AiComboData> Pointer )

            return value;
        }
    }
}
