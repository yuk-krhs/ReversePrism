using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Matchers                               000185D04638 ModelEnumListType List`1<RuleMatcher> List`1<RuleMatcher> List<RuleMatcher> Pointer
    public partial class UQueryMatcher : DataModel
    {
        public List<RuleMatcher>?                       M_Matchers                              { get; set; }

        public static UQueryMatcher? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UQueryMatcher() { Pointer= p0 };

            value.M_Matchers                                = GetEnumList<RuleMatcher>(new IntPtr(p + 0x010)); // 0245A680CEA8 0x10 M_Matchers                  ( 000185D04638 ModelEnumListType List`1<RuleMatcher> List`1<RuleMatcher> List<RuleMatcher> Pointer )

            return value;
        }
    }
}
