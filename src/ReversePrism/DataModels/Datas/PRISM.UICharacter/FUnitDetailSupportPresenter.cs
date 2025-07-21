using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     ModelClassType FUnitDetailSupportView FUnitDetailSupportView FUnitDetailSupportView Pointer
    // 028 GoSSkillContentPrefab                    ModelClassType SupportSkillContentView SupportSkillContentView SupportSkillContentView Pointer
    // 030 TrSSkillParent                           ModelClassType Transform Transform Transform Pointer
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

            value.View                                      = GetObject<FUnitDetailSupportView>(new IntPtr(p + 0x020), ReversePrism.DataModels.FUnitDetailSupportView.FromPointer); // 0x20 View                        ( ModelClassType FUnitDetailSupportView FUnitDetailSupportView FUnitDetailSupportView Pointer )
            value.GoSSkillContentPrefab                     = GetObject<SupportSkillContentView>(new IntPtr(p + 0x028), ReversePrism.DataModels.SupportSkillContentView.FromPointer); // 0x28 GoSSkillContentPrefab       ( ModelClassType SupportSkillContentView SupportSkillContentView SupportSkillContentView Pointer )
            value.TrSSkillParent                            = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 0x30 TrSSkillParent              ( ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
