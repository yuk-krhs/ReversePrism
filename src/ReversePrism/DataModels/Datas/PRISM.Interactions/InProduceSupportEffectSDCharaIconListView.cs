using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IconViewPrefab                           0001866DDE70 ModelClassType InProduceSupportEffectSDCharaIconView InProduceSupportEffectSDCharaIconView InProduceSupportEffectSDCharaIconView Pointer
    // 028 ContentArea                              0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 030 IconViews                                000185CEB338 ModelClassListType List`1<InProduceSupportEffectSDCharaIconView> List`1<InProduceSupportEffectSDCharaIconView> List<InProduceSupportEffectSDCharaIconView> Pointer
    public partial class InProduceSupportEffectSDCharaIconListView : DataModel
    {
        public InProduceSupportEffectSDCharaIconView?   IconViewPrefab                          { get; set; }
        public Transform?                               ContentArea                             { get; set; }
        public List<InProduceSupportEffectSDCharaIconView>? IconViews                               { get; set; }

        public static InProduceSupportEffectSDCharaIconListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InProduceSupportEffectSDCharaIconListView() { Pointer= p0 };

            value.IconViewPrefab                            = GetObject<InProduceSupportEffectSDCharaIconView>(new IntPtr(p + 0x020), ReversePrism.DataModels.InProduceSupportEffectSDCharaIconView.FromPointer); // 02466A152EE8 0x20 IconViewPrefab              ( 0001866DDE70 ModelClassType InProduceSupportEffectSDCharaIconView InProduceSupportEffectSDCharaIconView InProduceSupportEffectSDCharaIconView Pointer )
            value.ContentArea                               = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 02466A152F08 0x28 ContentArea                 ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.IconViews                                 = GetObjectList<InProduceSupportEffectSDCharaIconView>(new IntPtr(p + 0x030), ReversePrism.DataModels.InProduceSupportEffectSDCharaIconView.FromPointer); // 02466A152F28 0x30 IconViews                   ( 000185CEB338 ModelClassListType List`1<InProduceSupportEffectSDCharaIconView> List`1<InProduceSupportEffectSDCharaIconView> List<InProduceSupportEffectSDCharaIconView> Pointer )

            return value;
        }
    }
}
