using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_CustomIdentRegex                       Regex IL2CPP_TYPE_CLASS
    // 010 m_ContextStack                           Stack`1<MatchContext> IL2CPP_TYPE_GENERICINST
    // 018 M_CurrentContext                         ModelEnumType MatchContext MatchContext MatchContext Int32
    public partial class BaseStyleMatcher : DataModel
    {
        public MatchContext                             M_CurrentContext                        { get; set; }

        public static BaseStyleMatcher? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BaseStyleMatcher() { Pointer= p0 };

            value.M_CurrentContext                          = (MatchContext)GetInt32(new IntPtr(p + 0x018)); // 0x18 M_CurrentContext            ( ModelEnumType MatchContext MatchContext MatchContext Int32 )

            return value;
        }
    }
}
