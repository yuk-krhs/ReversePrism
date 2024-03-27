using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 EpisordClearCountText                    000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    public partial class ProfileFriendUserProgressEpisordClearCountView
    {
        public List<UITextMeshProUGUI>?                 EpisordClearCountText                   { get; set; }

        public static ProfileFriendUserProgressEpisordClearCountView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileFriendUserProgressEpisordClearCountView();

            value.EpisordClearCountText                     = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB741018 0x20 EpisordClearCountText       ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )

            return value;
        }
    }
}
