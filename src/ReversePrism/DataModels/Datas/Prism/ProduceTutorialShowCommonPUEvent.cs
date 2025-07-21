using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OnTapClose                               ModelClassType Action Action Action Pointer
    // 018 ConfigPath                               ModelPrimitiveType string string string String
    // 020 TutorialExternalAccess                   ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer
    public partial class ProduceTutorialShowCommonPUEvent : DataModel
    {
        public Action?                                  OnTapClose                              { get; set; }
        public string                                   ConfigPath                              { get; set; }
        public TutorialExternalAccess?                  TutorialExternalAccess                  { get; set; }

        public static ProduceTutorialShowCommonPUEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceTutorialShowCommonPUEvent() { Pointer= p0 };

            value.OnTapClose                                = GetObject<Action>(new IntPtr(p + 0x010), ReversePrism.DataModels.Action.FromPointer); // 0x10 OnTapClose                  ( ModelClassType Action Action Action Pointer )
            value.ConfigPath                                = GetString(new IntPtr(p + 0x018)); // 0x18 ConfigPath                  ( ModelPrimitiveType string string string String )
            value.TutorialExternalAccess                    = GetObject<TutorialExternalAccess>(new IntPtr(p + 0x020), ReversePrism.DataModels.TutorialExternalAccess.FromPointer); // 0x20 TutorialExternalAccess      ( ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer )

            return value;
        }
    }
}
