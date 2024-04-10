using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     00018654C320 ModelClassType FUnitDetailSupportView FUnitDetailSupportView FUnitDetailSupportView Pointer
    // 028 GoSSkillContentPrefab                    0001865F4B40 ModelClassType SupportSkillContentView SupportSkillContentView SupportSkillContentView Pointer
    // 030 TrSSkillParent                           0001866AA150 ModelClassType Transform Transform Transform Pointer
    public partial class FUnitDetailSupportPresenter : DataModel
    {
        public FUnitDetailSupportView?                  View                                    { get; set; }
        public SupportSkillContentView?                 GoSSkillContentPrefab                   { get; set; }
        public Transform?                               TrSSkillParent                          { get; set; }

        public static FUnitDetailSupportPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FUnitDetailSupportPresenter() { Pointer= p0 };

            value.View                                      = GetObject<FUnitDetailSupportView>(new IntPtr(p + 0x020), ReversePrism.DataModels.FUnitDetailSupportView.FromPointer); // 024665E1E4A8 0x20 View                        ( 00018654C320 ModelClassType FUnitDetailSupportView FUnitDetailSupportView FUnitDetailSupportView Pointer )
            value.GoSSkillContentPrefab                     = GetObject<SupportSkillContentView>(new IntPtr(p + 0x028), ReversePrism.DataModels.SupportSkillContentView.FromPointer); // 024665E1E4C8 0x28 GoSSkillContentPrefab       ( 0001865F4B40 ModelClassType SupportSkillContentView SupportSkillContentView SupportSkillContentView Pointer )
            value.TrSSkillParent                            = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 024665E1E4E8 0x30 TrSSkillParent              ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
