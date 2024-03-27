using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SupportEffectContentView                 0001865EF5A0 ModelClassType SupportEffectContentView SupportEffectContentView SupportEffectContentView Pointer
    // 028 SCharaEditSDCharaIconListView            0001866A7890 ModelClassType SCharaEditSDCharaIconListView SCharaEditSDCharaIconListView SCharaEditSDCharaIconListView Pointer
    public partial class SCharaEditSupportEffectContentView
    {
        public SupportEffectContentView?                SupportEffectContentView                { get; set; }
        public SCharaEditSDCharaIconListView?           SCharaEditSDCharaIconListView           { get; set; }

        public static SCharaEditSupportEffectContentView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SCharaEditSupportEffectContentView();

            value.SupportEffectContentView                  = GetObject<SupportEffectContentView>(new IntPtr(p + 0x020), ReversePrism.DataModels.SupportEffectContentView.FromPointer); // 0270DB591E88 0x20 SupportEffectContentView    ( 0001865EF5A0 ModelClassType SupportEffectContentView SupportEffectContentView SupportEffectContentView Pointer )
            value.SCharaEditSDCharaIconListView             = GetObject<SCharaEditSDCharaIconListView>(new IntPtr(p + 0x028), ReversePrism.DataModels.SCharaEditSDCharaIconListView.FromPointer); // 0270DB591EA8 0x28 SCharaEditSDCharaIconListView ( 0001866A7890 ModelClassType SCharaEditSDCharaIconListView SCharaEditSDCharaIconListView SCharaEditSDCharaIconListView Pointer )

            return value;
        }
    }
}
