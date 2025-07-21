using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GridView                                 ModelClassType ProfileFesUnitRankCountGridView ProfileFesUnitRankCountGridView ProfileFesUnitRankCountGridView Pointer
    // 028 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 030 RankStatusList                           ModelClassListType IUserProfileProduceTotalParameterRankStatus[] IUserProfileProduceTotalParameterRankStatus[] List<IUserProfileProduceTotalParameterRankStatus> Pointer
    // 038 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ProfileFesUnitRankCountPopupView : DataModel
    {
        public ProfileFesUnitRankCountGridView?         GridView                                { get; set; }
        public List<IUserProfileProduceTotalParameterRankStatus>? RankStatusList                          { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ProfileFesUnitRankCountPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileFesUnitRankCountPopupView() { Pointer= p0 };

            value.GridView                                  = GetObject<ProfileFesUnitRankCountGridView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProfileFesUnitRankCountGridView.FromPointer); // 0x20 GridView                    ( ModelClassType ProfileFesUnitRankCountGridView ProfileFesUnitRankCountGridView ProfileFesUnitRankCountGridView Pointer )
            value.RankStatusList                            = GetObjectList<IUserProfileProduceTotalParameterRankStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IUserProfileProduceTotalParameterRankStatus.FromPointer); // 0x30 RankStatusList              ( ModelClassListType IUserProfileProduceTotalParameterRankStatus[] IUserProfileProduceTotalParameterRankStatus[] List<IUserProfileProduceTotalParameterRankStatus> Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x38 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
