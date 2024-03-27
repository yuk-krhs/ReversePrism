using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsAutoPlay                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 011 IsPause                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 onSetIsPause                             Action`1<bool> IL2CPP_TYPE_GENERICINST
    // 020 onSetIsAutoPlay                          Action`1<bool> IL2CPP_TYPE_GENERICINST
    // 028 NonSleepDisposable                       0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class ADVAutoPlayController
    {
        public bool                                     IsAutoPlay                              { get; set; }
        public bool                                     IsPause                                 { get; set; }
        public IDisposable?                             NonSleepDisposable                      { get; set; }

        public static ADVAutoPlayController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ADVAutoPlayController();

            value.IsAutoPlay                                = GetBool(new IntPtr(p + 0x010)); // 0270D5DD3A48 0x10 IsAutoPlay                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsPause                                   = GetBool(new IntPtr(p + 0x011)); // 0270D5DD3A68 0x11 IsPause                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.NonSleepDisposable                        = GetObject<IDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.IDisposable.FromPointer); // 0270D5DD3AC8 0x28 NonSleepDisposable          ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
