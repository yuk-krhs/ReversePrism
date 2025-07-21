using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Delegate                                 ModelClassType UnityAction UnityAction UnityAction Pointer
    public partial class InvokableCall : DataModel
    {
        public UnityAction?                             Delegate                                { get; set; }

        public static InvokableCall? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InvokableCall() { Pointer= p0 };

            value.Delegate                                  = GetObject<UnityAction>(new IntPtr(p + 0x010), ReversePrism.DataModels.UnityAction.FromPointer); // 0x10 Delegate                    ( ModelClassType UnityAction UnityAction UnityAction Pointer )

            return value;
        }
    }
}
