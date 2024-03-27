using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BeforeLv                                 0001865F4260 ModelPrimitiveType int int int Int32
    // 014 AfterLv                                  0001865F4260 ModelPrimitiveType int int int Int32
    // 018 AcquisitionSkillContentVms               000185CEA9F8 ModelClassListType List`1<IdolSkillContentViewModel> List`1<IdolSkillContentViewModel> List<IdolSkillContentViewModel> Pointer
    // 020 IconVMs                                  000185D02F78 ModelClassListType List`1<RequiredItemIconViewModel> List`1<RequiredItemIconViewModel> List<RequiredItemIconViewModel> Pointer
    // 028 RequiredMoney                            0001865F8300 ModelPrimitiveType long long long Int64
    // 030 Money                                    0001865F8300 ModelPrimitiveType long long long Int64
    public partial class AwakeningExecutionConfirmedPopupViewModel
    {
        public int                                      BeforeLv                                { get; set; }
        public int                                      AfterLv                                 { get; set; }
        public List<IdolSkillContentViewModel>?         AcquisitionSkillContentVms              { get; set; }
        public List<RequiredItemIconViewModel>?         IconVMs                                 { get; set; }
        public long                                     RequiredMoney                           { get; set; }
        public long                                     Money                                   { get; set; }

        public static AwakeningExecutionConfirmedPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AwakeningExecutionConfirmedPopupViewModel();

            value.BeforeLv                                  = GetInt32(new IntPtr(p + 0x010)); // 0270D5F2B640 0x10 BeforeLv                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.AfterLv                                   = GetInt32(new IntPtr(p + 0x014)); // 0270D5F2B660 0x14 AfterLv                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.AcquisitionSkillContentVms                = GetObjectList<IdolSkillContentViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.IdolSkillContentViewModel.FromPointer); // 0270D5F2B680 0x18 AcquisitionSkillContentVms  ( 000185CEA9F8 ModelClassListType List`1<IdolSkillContentViewModel> List`1<IdolSkillContentViewModel> List<IdolSkillContentViewModel> Pointer )
            value.IconVMs                                   = GetObjectList<RequiredItemIconViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.RequiredItemIconViewModel.FromPointer); // 0270D5F2B6A0 0x20 IconVMs                     ( 000185D02F78 ModelClassListType List`1<RequiredItemIconViewModel> List`1<RequiredItemIconViewModel> List<RequiredItemIconViewModel> Pointer )
            value.RequiredMoney                             = GetInt64(new IntPtr(p + 0x028)); // 0270D5F2B6C0 0x28 RequiredMoney               ( 0001865F8300 ModelPrimitiveType long long long Int64 )
            value.Money                                     = GetInt64(new IntPtr(p + 0x030)); // 0270D5F2B6E0 0x30 Money                       ( 0001865F8300 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
