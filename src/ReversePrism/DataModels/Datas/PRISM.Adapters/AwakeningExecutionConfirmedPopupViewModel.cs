using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BeforeLv                                 ModelPrimitiveType int int int Int32
    // 014 AfterLv                                  ModelPrimitiveType int int int Int32
    // 018 AcquisitionSkillContentVms               ModelClassListType List`1<IdolSkillContentViewModel> List`1<IdolSkillContentViewModel> List<IdolSkillContentViewModel> Pointer
    // 020 IconVMs                                  ModelClassListType List`1<RequiredItemIconViewModel> List`1<RequiredItemIconViewModel> List<RequiredItemIconViewModel> Pointer
    // 028 RequiredMoney                            ModelPrimitiveType long long long Int64
    // 030 Money                                    ModelPrimitiveType long long long Int64
    public partial class AwakeningExecutionConfirmedPopupViewModel : DataModel
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
            var value   = new AwakeningExecutionConfirmedPopupViewModel() { Pointer= p0 };

            value.BeforeLv                                  = GetInt32(new IntPtr(p + 0x010)); // 0x10 BeforeLv                    ( ModelPrimitiveType int int int Int32 )
            value.AfterLv                                   = GetInt32(new IntPtr(p + 0x014)); // 0x14 AfterLv                     ( ModelPrimitiveType int int int Int32 )
            value.AcquisitionSkillContentVms                = GetObjectList<IdolSkillContentViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.IdolSkillContentViewModel.FromPointer); // 0x18 AcquisitionSkillContentVms  ( ModelClassListType List`1<IdolSkillContentViewModel> List`1<IdolSkillContentViewModel> List<IdolSkillContentViewModel> Pointer )
            value.IconVMs                                   = GetObjectList<RequiredItemIconViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.RequiredItemIconViewModel.FromPointer); // 0x20 IconVMs                     ( ModelClassListType List`1<RequiredItemIconViewModel> List`1<RequiredItemIconViewModel> List<RequiredItemIconViewModel> Pointer )
            value.RequiredMoney                             = GetInt64(new IntPtr(p + 0x028)); // 0x28 RequiredMoney               ( ModelPrimitiveType long long long Int64 )
            value.Money                                     = GetInt64(new IntPtr(p + 0x030)); // 0x30 Money                       ( ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
