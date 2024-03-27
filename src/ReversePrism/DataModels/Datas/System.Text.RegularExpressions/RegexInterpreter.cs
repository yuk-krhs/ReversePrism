using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 Code                                     00018663D0E0 ModelClassType RegexCode RegexCode RegexCode Pointer
    // 088 Culture                                  0001865B51E0 ModelClassType CultureInfo CultureInfo CultureInfo Pointer
    // 090 Operator                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 094 Codepos                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 098 RightToLeft                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 099 CaseInsensitive                          000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class RegexInterpreter
    {
        public RegexCode?                               Code                                    { get; set; }
        public CultureInfo?                             Culture                                 { get; set; }
        public int                                      Operator                                { get; set; }
        public int                                      Codepos                                 { get; set; }
        public bool                                     RightToLeft                             { get; set; }
        public bool                                     CaseInsensitive                         { get; set; }

        public static RegexInterpreter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RegexInterpreter();

            value.Code                                      = GetObject<RegexCode>(new IntPtr(p + 0x080), ReversePrism.DataModels.RegexCode.FromPointer); // 0270001EC828 0x80 Code                        ( 00018663D0E0 ModelClassType RegexCode RegexCode RegexCode Pointer )
            value.Culture                                   = GetObject<CultureInfo>(new IntPtr(p + 0x088), ReversePrism.DataModels.CultureInfo.FromPointer); // 0270001EC848 0x88 Culture                     ( 0001865B51E0 ModelClassType CultureInfo CultureInfo CultureInfo Pointer )
            value.Operator                                  = GetInt32(new IntPtr(p + 0x090)); // 0270001EC868 0x90 Operator                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Codepos                                   = GetInt32(new IntPtr(p + 0x094)); // 0270001EC888 0x94 Codepos                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RightToLeft                               = GetBool(new IntPtr(p + 0x098)); // 0270001EC8A8 0x98 RightToLeft                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CaseInsensitive                           = GetBool(new IntPtr(p + 0x099)); // 0270001EC8C8 0x99 CaseInsensitive             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
