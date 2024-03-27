using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 storyPlayConfirmationPopupFactory        PopupViewFactory`1<IStoryPlayConfirmationPopupView> IL2CPP_TYPE_GENERICINST
    // 028 storyContinuousPlayConfirmationPopupFactory PopupViewFactory`1<IStoryContinuousPlayConfirmationPopupView> IL2CPP_TYPE_GENERICINST
    public partial class StoryToAdvTransitionerView
    {

        public static StoryToAdvTransitionerView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryToAdvTransitionerView();


            return value;
        }
    }
}
