using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UnitSelectView                           000186730450 ModelClassType IntroductionUnitSelectView IntroductionUnitSelectView IntroductionUnitSelectView Pointer
    // 028 introductionLetterOverlayFactory         OverlayViewFactory`1<IIntroductionLetterOverlayView> IL2CPP_TYPE_GENERICINST
    // 030 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    public partial class IntroductionUnitLetterView : DataModel
    {
        public IntroductionUnitSelectView?              UnitSelectView                          { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static IntroductionUnitLetterView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionUnitLetterView() { Pointer= p0 };

            value.UnitSelectView                            = GetObject<IntroductionUnitSelectView>(new IntPtr(p + 0x020), ReversePrism.DataModels.IntroductionUnitSelectView.FromPointer); // 02466B6D5A98 0x20 UnitSelectView              ( 000186730450 ModelClassType IntroductionUnitSelectView IntroductionUnitSelectView IntroductionUnitSelectView Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x030), ReversePrism.DataModels.IResourceTag.FromPointer); // 02466B6D5AD8 0x30 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
