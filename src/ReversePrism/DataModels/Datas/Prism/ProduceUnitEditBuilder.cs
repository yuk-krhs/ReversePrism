using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     0001865999B0 ModelClassType ProduceUnitEditView ProduceUnitEditView ProduceUnitEditView Pointer
    // 028 TitleView                                0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 030 PIdolDetailPopupViewFactory              00018670A490 ModelClassType PIdolDetailPopupViewFactory PIdolDetailPopupViewFactory PIdolDetailPopupViewFactory Pointer
    // 038 SCharaDetailPopupViewFactory             0001866A44F0 ModelClassType SCharaDetailPopupViewFactory SCharaDetailPopupViewFactory SCharaDetailPopupViewFactory Pointer
    // 040 EditUnitNamePopupViewFactory             00018671C4D0 ModelClassType EditUnitNamePopupViewFactory EditUnitNamePopupViewFactory EditUnitNamePopupViewFactory Pointer
    // 048 ProducePreparationIdolSkillSelectPopupViewFactory 00018656FA60 ModelClassType ProducePreparationIdolSkillSelectPopupViewFactory ProducePreparationIdolSkillSelectPopupViewFactory ProducePreparationIdolSkillSelectPopupViewFactory Pointer
    // 050 ProduceSupportCharaSelectPopupViewFactory 000186588320 ModelClassType ProduceSupportCharaSelectPopupViewFactory ProduceSupportCharaSelectPopupViewFactory ProduceSupportCharaSelectPopupViewFactory Pointer
    // 058 SupportCharaUnitSetupPopupViewFactory    0001865E6980 ModelClassType SupportCharaUnitSetupPopupViewFactory SupportCharaUnitSetupPopupViewFactory SupportCharaUnitSetupPopupViewFactory Pointer
    public partial class ProduceUnitEditBuilder : DataModel
    {
        public ProduceUnitEditView?                     View                                    { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }
        public PIdolDetailPopupViewFactory?             PIdolDetailPopupViewFactory             { get; set; }
        public SCharaDetailPopupViewFactory?            SCharaDetailPopupViewFactory            { get; set; }
        public EditUnitNamePopupViewFactory?            EditUnitNamePopupViewFactory            { get; set; }
        public ProducePreparationIdolSkillSelectPopupViewFactory? ProducePreparationIdolSkillSelectPopupViewFactory { get; set; }
        public ProduceSupportCharaSelectPopupViewFactory? ProduceSupportCharaSelectPopupViewFactory { get; set; }
        public SupportCharaUnitSetupPopupViewFactory?   SupportCharaUnitSetupPopupViewFactory   { get; set; }

        public static ProduceUnitEditBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceUnitEditBuilder() { Pointer= p0 };

            value.View                                      = GetObject<ProduceUnitEditView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceUnitEditView.FromPointer); // 02466B689ED0 0x20 View                        ( 0001865999B0 ModelClassType ProduceUnitEditView ProduceUnitEditView ProduceUnitEditView Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x028), ReversePrism.DataModels.CommonTitleView.FromPointer); // 02466B689EF0 0x28 TitleView                   ( 0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.PIdolDetailPopupViewFactory               = GetObject<PIdolDetailPopupViewFactory>(new IntPtr(p + 0x030), ReversePrism.DataModels.PIdolDetailPopupViewFactory.FromPointer); // 02466B689F10 0x30 PIdolDetailPopupViewFactory ( 00018670A490 ModelClassType PIdolDetailPopupViewFactory PIdolDetailPopupViewFactory PIdolDetailPopupViewFactory Pointer )
            value.SCharaDetailPopupViewFactory              = GetObject<SCharaDetailPopupViewFactory>(new IntPtr(p + 0x038), ReversePrism.DataModels.SCharaDetailPopupViewFactory.FromPointer); // 02466B689F30 0x38 SCharaDetailPopupViewFactory ( 0001866A44F0 ModelClassType SCharaDetailPopupViewFactory SCharaDetailPopupViewFactory SCharaDetailPopupViewFactory Pointer )
            value.EditUnitNamePopupViewFactory              = GetObject<EditUnitNamePopupViewFactory>(new IntPtr(p + 0x040), ReversePrism.DataModels.EditUnitNamePopupViewFactory.FromPointer); // 02466B689F50 0x40 EditUnitNamePopupViewFactory ( 00018671C4D0 ModelClassType EditUnitNamePopupViewFactory EditUnitNamePopupViewFactory EditUnitNamePopupViewFactory Pointer )
            value.ProducePreparationIdolSkillSelectPopupViewFactory = GetObject<ProducePreparationIdolSkillSelectPopupViewFactory>(new IntPtr(p + 0x048), ReversePrism.DataModels.ProducePreparationIdolSkillSelectPopupViewFactory.FromPointer); // 02466B689F70 0x48 ProducePreparationIdolSkillSelectPopupViewFactory ( 00018656FA60 ModelClassType ProducePreparationIdolSkillSelectPopupViewFactory ProducePreparationIdolSkillSelectPopupViewFactory ProducePreparationIdolSkillSelectPopupViewFactory Pointer )
            value.ProduceSupportCharaSelectPopupViewFactory = GetObject<ProduceSupportCharaSelectPopupViewFactory>(new IntPtr(p + 0x050), ReversePrism.DataModels.ProduceSupportCharaSelectPopupViewFactory.FromPointer); // 02466B689F90 0x50 ProduceSupportCharaSelectPopupViewFactory ( 000186588320 ModelClassType ProduceSupportCharaSelectPopupViewFactory ProduceSupportCharaSelectPopupViewFactory ProduceSupportCharaSelectPopupViewFactory Pointer )
            value.SupportCharaUnitSetupPopupViewFactory     = GetObject<SupportCharaUnitSetupPopupViewFactory>(new IntPtr(p + 0x058), ReversePrism.DataModels.SupportCharaUnitSetupPopupViewFactory.FromPointer); // 02466B689FB0 0x58 SupportCharaUnitSetupPopupViewFactory ( 0001865E6980 ModelClassType SupportCharaUnitSetupPopupViewFactory SupportCharaUnitSetupPopupViewFactory SupportCharaUnitSetupPopupViewFactory Pointer )

            return value;
        }
    }
}
