using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IconViewPrefab                           ModelClassType SCharaEditSDCharaIconView SCharaEditSDCharaIconView SCharaEditSDCharaIconView Pointer
    // 028 ContentArea                              ModelClassType Transform Transform Transform Pointer
    // 030 IconViews                                ModelClassListType List`1<SCharaEditSDCharaIconView> List`1<SCharaEditSDCharaIconView> List<SCharaEditSDCharaIconView> Pointer
    public partial class SCharaEditSDCharaIconListView : DataModel
    {
        public SCharaEditSDCharaIconView?               IconViewPrefab                          { get; set; }
        public Transform?                               ContentArea                             { get; set; }
        public List<SCharaEditSDCharaIconView>?         IconViews                               { get; set; }

        public static SCharaEditSDCharaIconListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SCharaEditSDCharaIconListView() { Pointer= p0 };

            value.IconViewPrefab                            = GetObject<SCharaEditSDCharaIconView>(new IntPtr(p + 0x020), ReversePrism.DataModels.SCharaEditSDCharaIconView.FromPointer); // 0x20 IconViewPrefab              ( ModelClassType SCharaEditSDCharaIconView SCharaEditSDCharaIconView SCharaEditSDCharaIconView Pointer )
            value.ContentArea                               = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0x28 ContentArea                 ( ModelClassType Transform Transform Transform Pointer )
            value.IconViews                                 = GetObjectList<SCharaEditSDCharaIconView>(new IntPtr(p + 0x030), ReversePrism.DataModels.SCharaEditSDCharaIconView.FromPointer); // 0x30 IconViews                   ( ModelClassListType List`1<SCharaEditSDCharaIconView> List`1<SCharaEditSDCharaIconView> List<SCharaEditSDCharaIconView> Pointer )

            return value;
        }
    }
}
