using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsIMGUIContainer                         000186595210 ModelPrimitiveType bool bool bool Bool
    // 018 M_CallbackRegistry                       0001867513E0 ModelClassType EventCallbackRegistry EventCallbackRegistry EventCallbackRegistry Pointer
    // 000 ExecuteDefaultActionName                 string IL2CPP_TYPE_STRING
    // 000 ExecuteDefaultActionAtTargetName         string IL2CPP_TYPE_STRING
    public partial class CallbackEventHandler
    {
        public bool                                     IsIMGUIContainer                        { get; set; }
        public EventCallbackRegistry?                   M_CallbackRegistry                      { get; set; }

        public static CallbackEventHandler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CallbackEventHandler();

            value.IsIMGUIContainer                          = GetBool(new IntPtr(p + 0x010)); // 027003F07FF0 0x10 IsIMGUIContainer            ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.M_CallbackRegistry                        = GetObject<EventCallbackRegistry>(new IntPtr(p + 0x018), ReversePrism.DataModels.EventCallbackRegistry.FromPointer); // 027003F08010 0x18 M_CallbackRegistry          ( 0001867513E0 ModelClassType EventCallbackRegistry EventCallbackRegistry EventCallbackRegistry Pointer )

            return value;
        }
    }
}
