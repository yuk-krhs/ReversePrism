using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CutSceneName                             000186671910 ModelPrimitiveType string string string String
    // 028 callbackOnTriggerWithRootName            Action`1<string> IL2CPP_TYPE_GENERICINST
    // 030 CallbackOnTrigger                        0001866792B0 ModelClassType Action Action Action Pointer
    // 038 CallbackOffTrigger                       0001866792B0 ModelClassType Action Action Action Pointer
    public partial class CallbackHolder : DataModel
    {
        public string                                   CutSceneName                            { get; set; }
        public Action?                                  CallbackOnTrigger                       { get; set; }
        public Action?                                  CallbackOffTrigger                      { get; set; }

        public static CallbackHolder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CallbackHolder() { Pointer= p0 };

            value.CutSceneName                              = GetString(new IntPtr(p + 0x020)); // 024664DF55A0 0x20 CutSceneName                ( 000186671910 ModelPrimitiveType string string string String )
            value.CallbackOnTrigger                         = GetObject<Action>(new IntPtr(p + 0x030), ReversePrism.DataModels.Action.FromPointer); // 024664DF55E0 0x30 CallbackOnTrigger           ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.CallbackOffTrigger                        = GetObject<Action>(new IntPtr(p + 0x038), ReversePrism.DataModels.Action.FromPointer); // 024664DF5600 0x38 CallbackOffTrigger          ( 0001866792B0 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
