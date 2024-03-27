using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RpnTokens                                000185B81E90 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 018 HasVariables                             000186596860 ModelPrimitiveType bool bool bool Bool
    public partial class Expression
    {
        public List<string>?                            RpnTokens                               { get; set; }
        public bool                                     HasVariables                            { get; set; }

        public static Expression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Expression();

            value.RpnTokens                                 = GetStringList(new IntPtr(p + 0x010)); // 0270068A86D0 0x10 RpnTokens                   ( 000185B81E90 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.HasVariables                              = GetBool(new IntPtr(p + 0x018)); // 0270068A86F0 0x18 HasVariables                ( 000186596860 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
