using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScreenConnector                          ModelClassType MobileScreenConnectorPresenter MobileScreenConnectorPresenter MobileScreenConnectorPresenter Pointer
    // 018 NeedAnimationOnShow                      ModelPrimitiveType bool bool bool Bool
    // 019 NeedAnimationOnHide                      ModelPrimitiveType bool bool bool Bool
    public partial class MobileOverlayViewModel : DataModel
    {
        public MobileScreenConnectorPresenter?          ScreenConnector                         { get; set; }
        public bool                                     NeedAnimationOnShow                     { get; set; }
        public bool                                     NeedAnimationOnHide                     { get; set; }

        public static MobileOverlayViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MobileOverlayViewModel() { Pointer= p0 };

            value.ScreenConnector                           = GetObject<MobileScreenConnectorPresenter>(new IntPtr(p + 0x010), ReversePrism.DataModels.MobileScreenConnectorPresenter.FromPointer); // 0x10 ScreenConnector             ( ModelClassType MobileScreenConnectorPresenter MobileScreenConnectorPresenter MobileScreenConnectorPresenter Pointer )
            value.NeedAnimationOnShow                       = GetBool(new IntPtr(p + 0x018)); // 0x18 NeedAnimationOnShow         ( ModelPrimitiveType bool bool bool Bool )
            value.NeedAnimationOnHide                       = GetBool(new IntPtr(p + 0x019)); // 0x19 NeedAnimationOnHide         ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
