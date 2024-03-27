using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 tagName                                  string IL2CPP_TYPE_STRING
    // 010 OnTapClose                               0001866792B0 ModelClassType Action Action Action Pointer
    // 018 ConfigPath                               000186671910 ModelPrimitiveType string string string String
    // 020 TutorialExternalAccess                   0001866B98B0 ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer
    public partial class ProduceTutorialShowCommonPUEvent
    {
        public Action?                                  OnTapClose                              { get; set; }
        public string                                   ConfigPath                              { get; set; }
        public TutorialExternalAccess?                  TutorialExternalAccess                  { get; set; }

        public static ProduceTutorialShowCommonPUEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceTutorialShowCommonPUEvent();

            value.OnTapClose                                = GetObject<Action>(new IntPtr(p + 0x010), ReversePrism.DataModels.Action.FromPointer); // 0270D4D4A220 0x10 OnTapClose                  ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.ConfigPath                                = GetString(new IntPtr(p + 0x018)); // 0270D4D4A240 0x18 ConfigPath                  ( 000186671910 ModelPrimitiveType string string string String )
            value.TutorialExternalAccess                    = GetObject<TutorialExternalAccess>(new IntPtr(p + 0x020), ReversePrism.DataModels.TutorialExternalAccess.FromPointer); // 0270D4D4A260 0x20 TutorialExternalAccess      ( 0001866B98B0 ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer )

            return value;
        }
    }
}
