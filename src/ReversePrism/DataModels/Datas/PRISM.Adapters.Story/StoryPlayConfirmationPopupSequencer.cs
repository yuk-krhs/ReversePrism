using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScenarioName                             000186672F10 ModelPrimitiveType string string string String
    // 018 popupViewFactory                         IPopupViewFactory`1<IStoryPlayConfirmationPopupView> IL2CPP_TYPE_GENERICINST
    public partial class StoryPlayConfirmationPopupSequencer : DataModel
    {
        public string                                   ScenarioName                            { get; set; }

        public static StoryPlayConfirmationPopupSequencer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoryPlayConfirmationPopupSequencer() { Pointer= p0 };

            value.ScenarioName                              = GetString(new IntPtr(p + 0x010)); // 02466683EBC0 0x10 ScenarioName                ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
