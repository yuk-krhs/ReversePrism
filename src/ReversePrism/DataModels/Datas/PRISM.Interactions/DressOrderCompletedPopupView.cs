using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 OrderedCostumeContent                    ModelClassType OrderedCostumeContent OrderedCostumeContent OrderedCostumeContent Pointer
    // 028 OrderedCostumeContentParent              ModelClassType Transform Transform Transform Pointer
    // 030 onCostumeDetail                          Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 038 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 040 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class DressOrderCompletedPopupView : DataModel
    {
        public OrderedCostumeContent?                   OrderedCostumeContent                   { get; set; }
        public Transform?                               OrderedCostumeContentParent             { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static DressOrderCompletedPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DressOrderCompletedPopupView() { Pointer= p0 };

            value.OrderedCostumeContent                     = GetObject<OrderedCostumeContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.OrderedCostumeContent.FromPointer); // 0x20 OrderedCostumeContent       ( ModelClassType OrderedCostumeContent OrderedCostumeContent OrderedCostumeContent Pointer )
            value.OrderedCostumeContentParent               = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0x28 OrderedCostumeContentParent ( ModelClassType Transform Transform Transform Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x40 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
