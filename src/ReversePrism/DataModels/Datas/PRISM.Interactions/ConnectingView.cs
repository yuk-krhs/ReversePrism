using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Counter                                  000186714660 ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer
    // 028 ScopeCache                               0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class ConnectingView
    {
        public IntReactiveProperty?                     Counter                                 { get; set; }
        public IDisposable?                             ScopeCache                              { get; set; }

        public static ConnectingView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConnectingView();

            value.Counter                                   = GetObject<IntReactiveProperty>(new IntPtr(p + 0x020), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 0270D0A6A1C0 0x20 Counter                     ( 000186714660 ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )
            value.ScopeCache                                = GetObject<IDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.IDisposable.FromPointer); // 0270D0A6A1E0 0x28 ScopeCache                  ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
