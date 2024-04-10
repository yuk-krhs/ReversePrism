using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Delegate                               000186724C20 ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer
    // 018 m_State                                  <object> IL2CPP_TYPE_OBJECT
    public partial class InvocationContext : DataModel
    {
        public SendOrPostCallback?                      M_Delegate                              { get; set; }

        public static InvocationContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InvocationContext() { Pointer= p0 };

            value.M_Delegate                                = GetObject<SendOrPostCallback>(new IntPtr(p + 0x010), ReversePrism.DataModels.SendOrPostCallback.FromPointer); // 024666B4D030 0x10 M_Delegate                  ( 000186724C20 ModelClassType SendOrPostCallback SendOrPostCallback SendOrPostCallback Pointer )

            return value;
        }
    }
}
