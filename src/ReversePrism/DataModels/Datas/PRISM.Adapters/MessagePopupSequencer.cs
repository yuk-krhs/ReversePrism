using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 sequencer                                IClosableSequencer`2<int, IMessagePopupView> IL2CPP_TYPE_GENERICINST
    public partial class MessagePopupSequencer : DataModel
    {

        public static MessagePopupSequencer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MessagePopupSequencer() { Pointer= p0 };


            return value;
        }
    }
}
