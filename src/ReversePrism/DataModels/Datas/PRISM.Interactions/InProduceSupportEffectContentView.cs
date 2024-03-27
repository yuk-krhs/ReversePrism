using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SupportEffectContentView                 0001865EF5A0 ModelClassType SupportEffectContentView SupportEffectContentView SupportEffectContentView Pointer
    // 028 SCharaEditSDCharaIconListView            0001866DD9A0 ModelClassType InProduceSupportEffectSDCharaIconListView InProduceSupportEffectSDCharaIconListView InProduceSupportEffectSDCharaIconListView Pointer
    // 030 GrayOutCover                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class InProduceSupportEffectContentView
    {
        public SupportEffectContentView?                SupportEffectContentView                { get; set; }
        public InProduceSupportEffectSDCharaIconListView? SCharaEditSDCharaIconListView           { get; set; }
        public GameObject?                              GrayOutCover                            { get; set; }

        public static InProduceSupportEffectContentView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InProduceSupportEffectContentView();

            value.SupportEffectContentView                  = GetObject<SupportEffectContentView>(new IntPtr(p + 0x020), ReversePrism.DataModels.SupportEffectContentView.FromPointer); // 0270DA0FA5D8 0x20 SupportEffectContentView    ( 0001865EF5A0 ModelClassType SupportEffectContentView SupportEffectContentView SupportEffectContentView Pointer )
            value.SCharaEditSDCharaIconListView             = GetObject<InProduceSupportEffectSDCharaIconListView>(new IntPtr(p + 0x028), ReversePrism.DataModels.InProduceSupportEffectSDCharaIconListView.FromPointer); // 0270DA0FA5F8 0x28 SCharaEditSDCharaIconListView ( 0001866DD9A0 ModelClassType InProduceSupportEffectSDCharaIconListView InProduceSupportEffectSDCharaIconListView InProduceSupportEffectSDCharaIconListView Pointer )
            value.GrayOutCover                              = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA0FA618 0x30 GrayOutCover                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
