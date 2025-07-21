using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Ok                                       ModelPrimitiveType bool bool bool Bool
    // 018 Errors                                   ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 020 Results                                  ModelClassType Result Result Result Pointer
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

            value.Ok                                        = GetBool(new IntPtr(p + 0x010)); // 0x10 Ok                          ( ModelPrimitiveType bool bool bool Bool )
            value.Errors                                    = GetStringList(new IntPtr(p + 0x018)); // 0x18 Errors                      ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.Results                                   = GetObject<Result>(new IntPtr(p + 0x020), ReversePrism.DataModels.Result.FromPointer); // 0x20 Results                     ( ModelClassType Result Result Result Pointer )

            return value;
        }
    }
}
