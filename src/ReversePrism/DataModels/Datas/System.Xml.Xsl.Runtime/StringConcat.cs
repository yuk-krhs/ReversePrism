using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 S1                                       000186671910 ModelPrimitiveType string string string String
    // 018 S2                                       000186671910 ModelPrimitiveType string string string String
    // 020 S3                                       000186671910 ModelPrimitiveType string string string String
    // 028 S4                                       000186671910 ModelPrimitiveType string string string String
    // 030 Delimiter                                000186671910 ModelPrimitiveType string string string String
    // 038 StrList                                  000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 040 IdxStr                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class StringConcat : DataModel
    {
        public string                                   S1                                      { get; set; }
        public string                                   S2                                      { get; set; }
        public string                                   S3                                      { get; set; }
        public string                                   S4                                      { get; set; }
        public string                                   Delimiter                               { get; set; }
        public List<string>?                            StrList                                 { get; set; }
        public int                                      IdxStr                                  { get; set; }

        public static StringConcat? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StringConcat() { Pointer= p0 };

            value.S1                                        = GetString(new IntPtr(p + 0x010)); // 0246673EE948 0x10 S1                          ( 000186671910 ModelPrimitiveType string string string String )
            value.S2                                        = GetString(new IntPtr(p + 0x018)); // 0246673EE968 0x18 S2                          ( 000186671910 ModelPrimitiveType string string string String )
            value.S3                                        = GetString(new IntPtr(p + 0x020)); // 0246673EE988 0x20 S3                          ( 000186671910 ModelPrimitiveType string string string String )
            value.S4                                        = GetString(new IntPtr(p + 0x028)); // 0246673EE9A8 0x28 S4                          ( 000186671910 ModelPrimitiveType string string string String )
            value.Delimiter                                 = GetString(new IntPtr(p + 0x030)); // 0246673EE9C8 0x30 Delimiter                   ( 000186671910 ModelPrimitiveType string string string String )
            value.StrList                                   = GetStringList(new IntPtr(p + 0x038)); // 0246673EE9E8 0x38 StrList                     ( 000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.IdxStr                                    = GetInt32(new IntPtr(p + 0x040)); // 0246673EEA08 0x40 IdxStr                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
