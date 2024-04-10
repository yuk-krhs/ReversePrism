using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AdvScenarioInfo                          0001866EF2B0 ModelClassType IAdvScenarioInfo IAdvScenarioInfo IAdvScenarioInfo Pointer
    // 018 LogContent                               000185D2DD58 ModelClassListType List`1<TextLogData> List`1<TextLogData> List<TextLogData> Pointer
    // 020 CueSheetName                             000186671910 ModelPrimitiveType string string string String
    public partial class ADVLogInputData : DataModel
    {
        public IAdvScenarioInfo?                        AdvScenarioInfo                         { get; set; }
        public List<TextLogData>?                       LogContent                              { get; set; }
        public string                                   CueSheetName                            { get; set; }

        public static ADVLogInputData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ADVLogInputData() { Pointer= p0 };

            value.AdvScenarioInfo                           = GetObject<IAdvScenarioInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.IAdvScenarioInfo.FromPointer); // 024665E44D40 0x10 AdvScenarioInfo             ( 0001866EF2B0 ModelClassType IAdvScenarioInfo IAdvScenarioInfo IAdvScenarioInfo Pointer )
            value.LogContent                                = GetObjectList<TextLogData>(new IntPtr(p + 0x018), ReversePrism.DataModels.TextLogData.FromPointer); // 024665E44D60 0x18 LogContent                  ( 000185D2DD58 ModelClassListType List`1<TextLogData> List`1<TextLogData> List<TextLogData> Pointer )
            value.CueSheetName                              = GetString(new IntPtr(p + 0x020)); // 024665E44D80 0x20 CueSheetName                ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
