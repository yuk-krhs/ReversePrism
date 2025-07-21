using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SupportEffectContentView                 ModelClassType SupportEffectContentView SupportEffectContentView SupportEffectContentView Pointer
    // 028 SCharaEditSDCharaIconListView            ModelClassType InProduceSupportEffectSDCharaIconListView InProduceSupportEffectSDCharaIconListView InProduceSupportEffectSDCharaIconListView Pointer
    // 030 GrayOutCover                             ModelClassType GameObject GameObject GameObject Pointer
    public partial class InProduceSupportEffectContentView : DataModel
    {
        public SupportEffectContentView?                SupportEffectContentView                { get; set; }
        public InProduceSupportEffectSDCharaIconListView? SCharaEditSDCharaIconListView           { get; set; }
        public GameObject?                              GrayOutCover                            { get; set; }

        public static InProduceSupportEffectContentView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InProduceSupportEffectContentView() { Pointer= p0 };

            value.SupportEffectContentView                  = GetObject<SupportEffectContentView>(new IntPtr(p + 0x020), ReversePrism.DataModels.SupportEffectContentView.FromPointer); // 0x20 SupportEffectContentView    ( ModelClassType SupportEffectContentView SupportEffectContentView SupportEffectContentView Pointer )
            value.SCharaEditSDCharaIconListView             = GetObject<InProduceSupportEffectSDCharaIconListView>(new IntPtr(p + 0x028), ReversePrism.DataModels.InProduceSupportEffectSDCharaIconListView.FromPointer); // 0x28 SCharaEditSDCharaIconListView ( ModelClassType InProduceSupportEffectSDCharaIconListView InProduceSupportEffectSDCharaIconListView InProduceSupportEffectSDCharaIconListView Pointer )
            value.GrayOutCover                              = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 GrayOutCover                ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
