using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 ListView                                 0001865F9370 ModelClassType PvpUseListView PvpUseListView PvpUseListView Pointer
    public partial class PvpUserListPanelView : DataModel
    {
        public PvpUseListView?                          ListView                                { get; set; }

        public static PvpUserListPanelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpUserListPanelView() { Pointer= p0 };

            value.ListView                                  = GetObject<PvpUseListView>(new IntPtr(p + 0x038), ReversePrism.DataModels.PvpUseListView.FromPointer); // 02466A1A5B08 0x38 ListView                    ( 0001865F9370 ModelClassType PvpUseListView PvpUseListView PvpUseListView Pointer )

            return value;
        }
    }
}
