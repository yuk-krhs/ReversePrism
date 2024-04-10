using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 instance                                 NativeInputRuntime IL2CPP_TYPE_CLASS
    // 010 M_RunInBackground                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 M_ShutdownMethod                         0001866792B0 ModelClassType Action Action Action Pointer
    // 020 M_OnUpdate                               0001867052A0 ModelClassType InputUpdateDelegate InputUpdateDelegate InputUpdateDelegate Pointer
    // 028 m_OnBeforeUpdate                         Action`1<InputUpdateType> IL2CPP_TYPE_GENERICINST
    // 030 m_OnShouldRunUpdate                      Func`2<InputUpdateType, bool> IL2CPP_TYPE_GENERICINST
    // 038 M_PollingFrequency                       0001866656B0 ModelPrimitiveType float float float Single
    // 03C M_DidCallOnShutdown                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 040 m_FocusChangedMethod                     Action`1<bool> IL2CPP_TYPE_GENERICINST
    public partial class NativeInputRuntime : DataModel
    {
        public bool                                     M_RunInBackground                       { get; set; }
        public Action?                                  M_ShutdownMethod                        { get; set; }
        public InputUpdateDelegate?                     M_OnUpdate                              { get; set; }
        public float                                    M_PollingFrequency                      { get; set; }
        public bool                                     M_DidCallOnShutdown                     { get; set; }

        public static NativeInputRuntime? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeInputRuntime() { Pointer= p0 };

            value.M_RunInBackground                         = GetBool(new IntPtr(p + 0x010)); // 0245A2DD5990 0x10 M_RunInBackground           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_ShutdownMethod                          = GetObject<Action>(new IntPtr(p + 0x018), ReversePrism.DataModels.Action.FromPointer); // 0245A2DD59B0 0x18 M_ShutdownMethod            ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.M_OnUpdate                                = GetObject<InputUpdateDelegate>(new IntPtr(p + 0x020), ReversePrism.DataModels.InputUpdateDelegate.FromPointer); // 0245A2DD59D0 0x20 M_OnUpdate                  ( 0001867052A0 ModelClassType InputUpdateDelegate InputUpdateDelegate InputUpdateDelegate Pointer )
            value.M_PollingFrequency                        = GetSingle(new IntPtr(p + 0x038)); // 0245A2DD5A30 0x38 M_PollingFrequency          ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_DidCallOnShutdown                       = GetBool(new IntPtr(p + 0x03C)); // 0245A2DD5A50 0x3C M_DidCallOnShutdown         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
