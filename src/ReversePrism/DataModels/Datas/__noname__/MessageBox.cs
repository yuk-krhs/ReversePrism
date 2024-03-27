using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 048 Style                                    000186776180 ModelEnumType Style Style Style Int32
    public partial class MessageBox
    {
        public Style                                    Style                                   { get; set; }

        public static MessageBox? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MessageBox();

            value.Style                                     = (Style)GetInt32(new IntPtr(p + 0x048)); // 0270D918D648 0x48 Style                       ( 000186776180 ModelEnumType Style Style Style Int32 )

            return value;
        }
    }
}
