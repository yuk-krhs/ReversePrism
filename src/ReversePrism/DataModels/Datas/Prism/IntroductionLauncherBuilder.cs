using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     ModelClassType IntroductionLauncherView IntroductionLauncherView IntroductionLauncherView Pointer
    public partial class IntroductionLauncherBuilder : DataModel
    {
        public IntroductionLauncherView?                View                                    { get; set; }

        public static IntroductionLauncherBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionLauncherBuilder() { Pointer= p0 };

            value.View                                      = GetObject<IntroductionLauncherView>(new IntPtr(p + 0x020), ReversePrism.DataModels.IntroductionLauncherView.FromPointer); // 0x20 View                        ( ModelClassType IntroductionLauncherView IntroductionLauncherView IntroductionLauncherView Pointer )

            return value;
        }
    }
}
