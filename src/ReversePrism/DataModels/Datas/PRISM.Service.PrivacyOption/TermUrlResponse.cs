using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Ok                                       000186595960 ModelPrimitiveType bool bool bool Bool
    // 018 Errors                                   000185D0D6C8 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 020 Results                                  000185D2DB18 ModelClassListType List`1<Result> List`1<Result> List<Result> Pointer
    public partial class TermUrlResponse : DataModel
    {
        public bool                                     Ok                                      { get; set; }
        public List<string>?                            Errors                                  { get; set; }
        public List<Result>?                            Results                                 { get; set; }

        public static TermUrlResponse? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TermUrlResponse() { Pointer= p0 };

            value.Ok                                        = GetBool(new IntPtr(p + 0x010)); // 0245A4E3AA18 0x10 Ok                          ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Errors                                    = GetStringList(new IntPtr(p + 0x018)); // 0245A4E3AA38 0x18 Errors                      ( 000185D0D6C8 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.Results                                   = GetObjectList<Result>(new IntPtr(p + 0x020), ReversePrism.DataModels.Result.FromPointer); // 0245A4E3AA58 0x20 Results                     ( 000185D2DB18 ModelClassListType List`1<Result> List`1<Result> List<Result> Pointer )

            return value;
        }
    }
}
