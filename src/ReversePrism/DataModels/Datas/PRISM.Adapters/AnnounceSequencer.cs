using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 sequencer                                IClosableSequencer`2<Unit, IAnnounceOverlayView> IL2CPP_TYPE_GENERICINST
    // 018 detailSequencer                          IClosableSequencer`2<int, IAnnounceDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 020 IsShowList                               000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class AnnounceSequencer
    {
        public bool                                     IsShowList                              { get; set; }

        public static AnnounceSequencer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnnounceSequencer();

            value.IsShowList                                = GetBool(new IntPtr(p + 0x020)); // 0270039A7D30 0x20 IsShowList                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
