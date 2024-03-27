using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BirthdayTextView                         00018675F650 ModelClassType BirthdayTextView BirthdayTextView BirthdayTextView Pointer
    public partial class RegisterBirthdayConfirmView
    {
        public BirthdayTextView?                        BirthdayTextView                        { get; set; }

        public static RegisterBirthdayConfirmView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RegisterBirthdayConfirmView();

            value.BirthdayTextView                          = GetObject<BirthdayTextView>(new IntPtr(p + 0x020), ReversePrism.DataModels.BirthdayTextView.FromPointer); // 0270D5511FB0 0x20 BirthdayTextView            ( 00018675F650 ModelClassType BirthdayTextView BirthdayTextView BirthdayTextView Pointer )

            return value;
        }
    }
}
