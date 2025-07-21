using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 Code                                     ModelClassType RegexCode RegexCode RegexCode Pointer
    // 088 Culture                                  ModelClassType CultureInfo CultureInfo CultureInfo Pointer
    // 090 Operator                                 ModelPrimitiveType int int int Int32
    // 094 Codepos                                  ModelPrimitiveType int int int Int32
    // 098 RightToLeft                              ModelPrimitiveType bool bool bool Bool
    // 099 CaseInsensitive                          ModelPrimitiveType bool bool bool Bool
    public partial class RegexInterpreter : DataModel
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
            var value   = new RegexInterpreter() { Pointer= p0 };

            value.Code                                      = GetObject<RegexCode>(new IntPtr(p + 0x080), ReversePrism.DataModels.RegexCode.FromPointer); // 0x80 Code                        ( ModelClassType RegexCode RegexCode RegexCode Pointer )
            value.Culture                                   = GetObject<CultureInfo>(new IntPtr(p + 0x088), ReversePrism.DataModels.CultureInfo.FromPointer); // 0x88 Culture                     ( ModelClassType CultureInfo CultureInfo CultureInfo Pointer )
            value.Operator                                  = GetInt32(new IntPtr(p + 0x090)); // 0x90 Operator                    ( ModelPrimitiveType int int int Int32 )
            value.Codepos                                   = GetInt32(new IntPtr(p + 0x094)); // 0x94 Codepos                     ( ModelPrimitiveType int int int Int32 )
            value.RightToLeft                               = GetBool(new IntPtr(p + 0x098)); // 0x98 RightToLeft                 ( ModelPrimitiveType bool bool bool Bool )
            value.CaseInsensitive                           = GetBool(new IntPtr(p + 0x099)); // 0x99 CaseInsensitive             ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
