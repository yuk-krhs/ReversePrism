using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AdvView                                  00018657B5B0 ModelClassType IInGameResultADVView IInGameResultADVView IInGameResultADVView Pointer
    public partial class InGameResultADVPresenter
    {
        public IInGameResultADVView?                    AdvView                                 { get; set; }

        public static InGameResultADVPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InGameResultADVPresenter();

            value.AdvView                                   = GetObject<IInGameResultADVView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IInGameResultADVView.FromPointer); // 0270D681BA28 0x10 AdvView                     ( 00018657B5B0 ModelClassType IInGameResultADVView IInGameResultADVView IInGameResultADVView Pointer )

            return value;
        }
    }
}
