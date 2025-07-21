using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<UsageRule> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SelectorFieldNumber                      int IL2CPP_TYPE_I4
    // 018 Selector                                 ModelPrimitiveType string string string String
    // 000 AllowUnregisteredCallsFieldNumber        int IL2CPP_TYPE_I4
    // 020 AllowUnregisteredCalls                   ModelPrimitiveType bool bool bool Bool
    // 000 SkipServiceControlFieldNumber            int IL2CPP_TYPE_I4
    // 021 SkipServiceControl                       ModelPrimitiveType bool bool bool Bool
    public partial class UsageRule : DataModel
    {
        public string                                   Selector                                { get; set; }
        public bool                                     AllowUnregisteredCalls                  { get; set; }
        public bool                                     SkipServiceControl                      { get; set; }

        public static UsageRule? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UsageRule() { Pointer= p0 };

            value.Selector                                  = GetString(new IntPtr(p + 0x018)); // 0x18 Selector                    ( ModelPrimitiveType string string string String )
            value.AllowUnregisteredCalls                    = GetBool(new IntPtr(p + 0x020)); // 0x20 AllowUnregisteredCalls      ( ModelPrimitiveType bool bool bool Bool )
            value.SkipServiceControl                        = GetBool(new IntPtr(p + 0x021)); // 0x21 SkipServiceControl          ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
