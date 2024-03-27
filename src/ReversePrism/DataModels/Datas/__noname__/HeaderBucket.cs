using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Parsed                                   <object> IL2CPP_TYPE_OBJECT
    // 018 Values                                   000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 020 CustomToString                           Func`2<<object>, string> IL2CPP_TYPE_GENERICINST
    public partial class HeaderBucket
    {
        public List<string>?                            Values                                  { get; set; }

        public static HeaderBucket? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HeaderBucket();

            value.Values                                    = GetStringList(new IntPtr(p + 0x018)); // 0270DB86B220 0x18 Values                      ( 000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )

            return value;
        }
    }
}
