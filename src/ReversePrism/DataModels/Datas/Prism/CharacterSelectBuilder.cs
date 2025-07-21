using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     ModelClassType CharacterSelectView CharacterSelectView CharacterSelectView Pointer
    // 028 TitleView                                ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 030 PiView                                   ModelClassType ProduceIdolListView ProduceIdolListView ProduceIdolListView Pointer
    // 038 ScView                                   ModelClassType SupportCharaListView SupportCharaListView SupportCharaListView Pointer
    // 040 PiUpgradingButtonView                    ModelClassType PIdolUpgradingButtonView PIdolUpgradingButtonView PIdolUpgradingButtonView Pointer
    // 048 ScUpgradingButtonView                    ModelClassType SCharaUpgradingButtonView SCharaUpgradingButtonView SCharaUpgradingButtonView Pointer
    public partial class CharacterSelectBuilder : DataModel
    {
        public CharacterSelectView?                     View                                    { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }
        public ProduceIdolListView?                     PiView                                  { get; set; }
        public SupportCharaListView?                    ScView                                  { get; set; }
        public PIdolUpgradingButtonView?                PiUpgradingButtonView                   { get; set; }
        public SCharaUpgradingButtonView?               ScUpgradingButtonView                   { get; set; }

        public static CharacterSelectBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterSelectBuilder() { Pointer= p0 };

            value.View                                      = GetObject<CharacterSelectView>(new IntPtr(p + 0x020), ReversePrism.DataModels.CharacterSelectView.FromPointer); // 0x20 View                        ( ModelClassType CharacterSelectView CharacterSelectView CharacterSelectView Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x028), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0x28 TitleView                   ( ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.PiView                                    = GetObject<ProduceIdolListView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProduceIdolListView.FromPointer); // 0x30 PiView                      ( ModelClassType ProduceIdolListView ProduceIdolListView ProduceIdolListView Pointer )
            value.ScView                                    = GetObject<SupportCharaListView>(new IntPtr(p + 0x038), ReversePrism.DataModels.SupportCharaListView.FromPointer); // 0x38 ScView                      ( ModelClassType SupportCharaListView SupportCharaListView SupportCharaListView Pointer )
            value.PiUpgradingButtonView                     = GetObject<PIdolUpgradingButtonView>(new IntPtr(p + 0x040), ReversePrism.DataModels.PIdolUpgradingButtonView.FromPointer); // 0x40 PiUpgradingButtonView       ( ModelClassType PIdolUpgradingButtonView PIdolUpgradingButtonView PIdolUpgradingButtonView Pointer )
            value.ScUpgradingButtonView                     = GetObject<SCharaUpgradingButtonView>(new IntPtr(p + 0x048), ReversePrism.DataModels.SCharaUpgradingButtonView.FromPointer); // 0x48 ScUpgradingButtonView       ( ModelClassType SCharaUpgradingButtonView SCharaUpgradingButtonView SCharaUpgradingButtonView Pointer )

            return value;
        }
    }
}
