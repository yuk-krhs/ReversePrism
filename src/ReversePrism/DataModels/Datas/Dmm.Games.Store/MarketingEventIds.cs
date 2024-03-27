using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FirstBoot                                000185CED588 ModelPrimitiveListType List`1<long> List`1<long> List<long> Pointer
    // 018 Boot                                     000185CED588 ModelPrimitiveListType List`1<long> List`1<long> List<long> Pointer
    // 020 Signup                                   000185CED588 ModelPrimitiveListType List`1<long> List`1<long> List<long> Pointer
    // 028 Spend                                    000185CED588 ModelPrimitiveListType List`1<long> List`1<long> List<long> Pointer
    public partial class MarketingEventIds
    {
        public List<long>?                              FirstBoot                               { get; set; }
        public List<long>?                              Boot                                    { get; set; }
        public List<long>?                              Signup                                  { get; set; }
        public List<long>?                              Spend                                   { get; set; }

        public static MarketingEventIds? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MarketingEventIds();

            value.FirstBoot                                 = GetInt64List(new IntPtr(p + 0x010)); // 0270DB49B900 0x10 FirstBoot                   ( 000185CED588 ModelPrimitiveListType List`1<long> List`1<long> List<long> Pointer )
            value.Boot                                      = GetInt64List(new IntPtr(p + 0x018)); // 0270DB49B920 0x18 Boot                        ( 000185CED588 ModelPrimitiveListType List`1<long> List`1<long> List<long> Pointer )
            value.Signup                                    = GetInt64List(new IntPtr(p + 0x020)); // 0270DB49B940 0x20 Signup                      ( 000185CED588 ModelPrimitiveListType List`1<long> List`1<long> List<long> Pointer )
            value.Spend                                     = GetInt64List(new IntPtr(p + 0x028)); // 0270DB49B960 0x28 Spend                       ( 000185CED588 ModelPrimitiveListType List`1<long> List`1<long> List<long> Pointer )

            return value;
        }
    }
}
