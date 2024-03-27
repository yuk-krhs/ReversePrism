using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Guid                                     0001866722E0 ModelPrimitiveType string string string String
    // 030 Selector                                 0001866722E0 ModelPrimitiveType string string string String
    // 038 Fields                                   000185D0D6C8 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 040 Count                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 044 StartIndex                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 048 Filter                                   00018657F900 ModelClassType Filter Filter Filter Pointer
    public partial class PeopleParameter
    {
        public string                                   Guid                                    { get; set; }
        public string                                   Selector                                { get; set; }
        public List<string>?                            Fields                                  { get; set; }
        public int                                      Count                                   { get; set; }
        public int                                      StartIndex                              { get; set; }
        public Filter?                                  Filter                                  { get; set; }

        public static PeopleParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PeopleParameter();

            value.Guid                                      = GetString(new IntPtr(p + 0x028)); // 0270DB49A270 0x28 Guid                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Selector                                  = GetString(new IntPtr(p + 0x030)); // 0270DB49A290 0x30 Selector                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Fields                                    = GetStringList(new IntPtr(p + 0x038)); // 0270DB49A2B0 0x38 Fields                      ( 000185D0D6C8 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.Count                                     = GetInt32(new IntPtr(p + 0x040)); // 0270DB49A2D0 0x40 Count                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.StartIndex                                = GetInt32(new IntPtr(p + 0x044)); // 0270DB49A2F0 0x44 StartIndex                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Filter                                    = GetObject<Filter>(new IntPtr(p + 0x048), ReversePrism.DataModels.Filter.FromPointer); // 0270DB49A310 0x48 Filter                      ( 00018657F900 ModelClassType Filter Filter Filter Pointer )

            return value;
        }
    }
}
