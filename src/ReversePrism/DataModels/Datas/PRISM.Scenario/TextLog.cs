using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 dicConvertID                             Dictionary`2<string, int> IL2CPP_TYPE_GENERICINST
    // 018 SpeakerTable                             000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 020 ListTextLogData                          000185D2DD58 ModelClassListType List`1<TextLogData> List`1<TextLogData> List<TextLogData> Pointer
    // 028 UnitIdol                                 000185CAF1A8 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 030 ConvertList                              000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    public partial class TextLog
    {
        public List<string>?                            SpeakerTable                            { get; set; }
        public List<TextLogData>?                       ListTextLogData                         { get; set; }
        public List<UnitIdol>?                          UnitIdol                                { get; set; }
        public List<int>?                               ConvertList                             { get; set; }

        public static TextLog? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextLog();

            value.SpeakerTable                              = GetStringList(new IntPtr(p + 0x018)); // 0270069C7F30 0x18 SpeakerTable                ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.ListTextLogData                           = GetObjectList<TextLogData>(new IntPtr(p + 0x020), ReversePrism.DataModels.TextLogData.FromPointer); // 0270069C7F50 0x20 ListTextLogData             ( 000185D2DD58 ModelClassListType List`1<TextLogData> List`1<TextLogData> List<TextLogData> Pointer )
            value.UnitIdol                                  = GetObjectList<UnitIdol>(new IntPtr(p + 0x028), ReversePrism.DataModels.UnitIdol.FromPointer); // 0270069C7F70 0x28 UnitIdol                    ( 000185CAF1A8 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.ConvertList                               = GetInt32List(new IntPtr(p + 0x030)); // 0270069C7F90 0x30 ConvertList                 ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
