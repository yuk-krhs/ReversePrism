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
    // 038 Pid                                      0001866722E0 ModelPrimitiveType string string string String
    // 040 Count                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 044 StartIndex                               0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class IgnoreListParameter
    {
        public string                                   Guid                                    { get; set; }
        public string                                   Selector                                { get; set; }
        public string                                   Pid                                     { get; set; }
        public int                                      Count                                   { get; set; }
        public int                                      StartIndex                              { get; set; }

        public static IgnoreListParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IgnoreListParameter();

            value.Guid                                      = GetString(new IntPtr(p + 0x028)); // 0270DB499DD0 0x28 Guid                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Selector                                  = GetString(new IntPtr(p + 0x030)); // 0270DB499DF0 0x30 Selector                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Pid                                       = GetString(new IntPtr(p + 0x038)); // 0270DB499E10 0x38 Pid                         ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Count                                     = GetInt32(new IntPtr(p + 0x040)); // 0270DB499E30 0x40 Count                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.StartIndex                                = GetInt32(new IntPtr(p + 0x044)); // 0270DB499E50 0x44 StartIndex                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
