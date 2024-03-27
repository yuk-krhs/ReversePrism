using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BirthdayTextView                         00018675F650 ModelClassType BirthdayTextView BirthdayTextView BirthdayTextView Pointer
    // 028 onClosed                                 Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 030 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class RegisterBirthdayConfirmPopupView
    {
        public BirthdayTextView?                        BirthdayTextView                        { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static RegisterBirthdayConfirmPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RegisterBirthdayConfirmPopupView();

            value.BirthdayTextView                          = GetObject<BirthdayTextView>(new IntPtr(p + 0x020), ReversePrism.DataModels.BirthdayTextView.FromPointer); // 0270DB7BD9E0 0x20 BirthdayTextView            ( 00018675F650 ModelClassType BirthdayTextView BirthdayTextView BirthdayTextView Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x030), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DB7BDA20 0x30 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
