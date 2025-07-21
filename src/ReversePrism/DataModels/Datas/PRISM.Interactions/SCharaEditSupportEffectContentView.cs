using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SupportEffectContentView                 ModelClassType SupportEffectContentView SupportEffectContentView SupportEffectContentView Pointer
    // 028 SCharaEditSDCharaIconListView            ModelClassType SCharaEditSDCharaIconListView SCharaEditSDCharaIconListView SCharaEditSDCharaIconListView Pointer
    public partial class SCharaEditSupportEffectContentView : DataModel
    {
        public SupportEffectContentView?                SupportEffectContentView                { get; set; }
        public SCharaEditSDCharaIconListView?           SCharaEditSDCharaIconListView           { get; set; }

        public static SCharaEditSupportEffectContentView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SCharaEditSupportEffectContentView() { Pointer= p0 };

            value.SupportEffectContentView                  = GetObject<SupportEffectContentView>(new IntPtr(p + 0x020), ReversePrism.DataModels.SupportEffectContentView.FromPointer); // 0x20 SupportEffectContentView    ( ModelClassType SupportEffectContentView SupportEffectContentView SupportEffectContentView Pointer )
            value.SCharaEditSDCharaIconListView             = GetObject<SCharaEditSDCharaIconListView>(new IntPtr(p + 0x028), ReversePrism.DataModels.SCharaEditSDCharaIconListView.FromPointer); // 0x28 SCharaEditSDCharaIconListView ( ModelClassType SCharaEditSDCharaIconListView SCharaEditSDCharaIconListView SCharaEditSDCharaIconListView Pointer )

            return value;
        }
    }
}
