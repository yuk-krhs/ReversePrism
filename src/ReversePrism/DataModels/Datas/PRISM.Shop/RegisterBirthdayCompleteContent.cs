using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 View                                     000186643760 ModelClassType RegisterBirthdayCompleteView RegisterBirthdayCompleteView RegisterBirthdayCompleteView Pointer
    public partial class RegisterBirthdayCompleteContent
    {
        public RegisterBirthdayCompleteView?            View                                    { get; set; }

        public static RegisterBirthdayCompleteContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RegisterBirthdayCompleteContent();

            value.View                                      = GetObject<RegisterBirthdayCompleteView>(new IntPtr(p + 0x060), ReversePrism.DataModels.RegisterBirthdayCompleteView.FromPointer); // 0270D5511CC8 0x60 View                        ( 000186643760 ModelClassType RegisterBirthdayCompleteView RegisterBirthdayCompleteView RegisterBirthdayCompleteView Pointer )

            return value;
        }
    }
}
