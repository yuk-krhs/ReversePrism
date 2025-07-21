using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Counter                                  ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer
    // 028 ScopeCache                               ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class ConnectingView : DataModel
    {
        public IntReactiveProperty?                     Counter                                 { get; set; }
        public IDisposable?                             ScopeCache                              { get; set; }

        public static ConnectingView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConnectingView() { Pointer= p0 };

            value.Counter                                   = GetObject<IntReactiveProperty>(new IntPtr(p + 0x020), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 0x20 Counter                     ( ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )
            value.ScopeCache                                = GetObject<IDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.IDisposable.FromPointer); // 0x28 ScopeCache                  ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
