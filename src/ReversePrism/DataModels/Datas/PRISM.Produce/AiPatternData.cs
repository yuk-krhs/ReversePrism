using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ActionPatternId                          ModelPrimitiveType int int int Int32
    // 014 Score                                    ModelPrimitiveType int int int Int32
    // 018 ComboDataList                            ModelClassListType List`1<AiComboData> List`1<AiComboData> List<AiComboData> Pointer
    public partial class AiPatternData : DataModel
    {
        public int                                      ActionPatternId                         { get; set; }
        public int                                      Score                                   { get; set; }
        public List<AiComboData>?                       ComboDataList                           { get; set; }

        public static AiPatternData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AiPatternData() { Pointer= p0 };

            value.ActionPatternId                           = GetInt32(new IntPtr(p + 0x010)); // 0x10 ActionPatternId             ( ModelPrimitiveType int int int Int32 )
            value.Score                                     = GetInt32(new IntPtr(p + 0x014)); // 0x14 Score                       ( ModelPrimitiveType int int int Int32 )
            value.ComboDataList                             = GetObjectList<AiComboData>(new IntPtr(p + 0x018), ReversePrism.DataModels.AiComboData.FromPointer); // 0x18 ComboDataList               ( ModelClassListType List`1<AiComboData> List`1<AiComboData> List<AiComboData> Pointer )

            return value;
        }
    }
}
