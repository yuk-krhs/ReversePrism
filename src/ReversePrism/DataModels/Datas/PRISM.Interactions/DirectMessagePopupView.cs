using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ListView                                 ModelClassType DirectMessageListView DirectMessageListView DirectMessageListView Pointer
    // 028 Message                                  ModelClassType DirectMessageViewModel DirectMessageViewModel DirectMessageViewModel Pointer
    // 030 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 038 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class DirectMessagePopupView : DataModel
    {
        public DirectMessageListView?                   ListView                                { get; set; }
        public DirectMessageViewModel?                  Message                                 { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static DirectMessagePopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DirectMessagePopupView() { Pointer= p0 };

            value.ListView                                  = GetObject<DirectMessageListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.DirectMessageListView.FromPointer); // 0x20 ListView                    ( ModelClassType DirectMessageListView DirectMessageListView DirectMessageListView Pointer )
            value.Message                                   = GetObject<DirectMessageViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.DirectMessageViewModel.FromPointer); // 0x28 Message                     ( ModelClassType DirectMessageViewModel DirectMessageViewModel DirectMessageViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x38 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
