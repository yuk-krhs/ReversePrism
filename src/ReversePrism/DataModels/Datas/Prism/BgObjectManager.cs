using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TimeOfDayTable                           ModelPrimitiveListType string[] string[] List<string> Pointer
    // 028 WeatherTable                             ModelPrimitiveListType string[] string[] List<string> Pointer
    // 030 SeasonTable                              ModelPrimitiveListType string[] string[] List<string> Pointer
    // 038 NatureEventTable                         ModelPrimitiveListType string[] string[] List<string> Pointer
    // 040 CultureEventTable                        ModelPrimitiveListType string[] string[] List<string> Pointer
    // 048 tables                                   string[][] IL2CPP_TYPE_SZARRAY
    public partial class BgObjectManager : DataModel
    {
        public List<string>?                            TimeOfDayTable                          { get; set; }
        public List<string>?                            WeatherTable                            { get; set; }
        public List<string>?                            SeasonTable                             { get; set; }
        public List<string>?                            NatureEventTable                        { get; set; }
        public List<string>?                            CultureEventTable                       { get; set; }

        public static BgObjectManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BgObjectManager() { Pointer= p0 };

            value.TimeOfDayTable                            = GetStringList(new IntPtr(p + 0x020)); // 0x20 TimeOfDayTable              ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.WeatherTable                              = GetStringList(new IntPtr(p + 0x028)); // 0x28 WeatherTable                ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.SeasonTable                               = GetStringList(new IntPtr(p + 0x030)); // 0x30 SeasonTable                 ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.NatureEventTable                          = GetStringList(new IntPtr(p + 0x038)); // 0x38 NatureEventTable            ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.CultureEventTable                         = GetStringList(new IntPtr(p + 0x040)); // 0x40 CultureEventTable           ( ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
