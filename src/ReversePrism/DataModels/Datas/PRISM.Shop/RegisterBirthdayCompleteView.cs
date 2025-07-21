using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BirthdayTextView                         ModelClassType BirthdayTextView BirthdayTextView BirthdayTextView Pointer
    public partial class RegisterBirthdayCompleteView : DataModel
    {
        public BirthdayTextView?                        BirthdayTextView                        { get; set; }

        public static RegisterBirthdayCompleteView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RegisterBirthdayCompleteView() { Pointer= p0 };

            value.BirthdayTextView                          = GetObject<BirthdayTextView>(new IntPtr(p + 0x020), ReversePrism.DataModels.BirthdayTextView.FromPointer); // 0x20 BirthdayTextView            ( ModelClassType BirthdayTextView BirthdayTextView BirthdayTextView Pointer )

            return value;
        }
    }
}
