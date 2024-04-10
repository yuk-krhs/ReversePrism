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
    // 020 Results                                  00018651BEB0 ModelClassType Result Result Result Pointer
    public partial class ConsentResponse : DataModel
    {
        public bool                                     Ok                                      { get; set; }
        public List<string>?                            Errors                                  { get; set; }
        public Result?                                  Results                                 { get; set; }

        public static ConsentResponse? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConsentResponse() { Pointer= p0 };

            value.Ok                                        = GetBool(new IntPtr(p + 0x010)); // 0245A4E3DBF0 0x10 Ok                          ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Errors                                    = GetStringList(new IntPtr(p + 0x018)); // 0245A4E3DC10 0x18 Errors                      ( 000185D0D6C8 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.Results                                   = GetObject<Result>(new IntPtr(p + 0x020), ReversePrism.DataModels.Result.FromPointer); // 0245A4E3DC30 0x20 Results                     ( 00018651BEB0 ModelClassType Result Result Result Pointer )

            return value;
        }
    }
}
