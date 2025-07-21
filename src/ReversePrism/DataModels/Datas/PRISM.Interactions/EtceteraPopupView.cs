using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ListView                                 ModelClassType EtceteraCellListView EtceteraCellListView EtceteraCellListView Pointer
    // 028 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 030 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class EtceteraPopupView : DataModel
    {
        public EtceteraCellListView?                    ListView                                { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static EtceteraPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EtceteraPopupView() { Pointer= p0 };

            value.ListView                                  = GetObject<EtceteraCellListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.EtceteraCellListView.FromPointer); // 0x20 ListView                    ( ModelClassType EtceteraCellListView EtceteraCellListView EtceteraCellListView Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x030), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x30 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
