using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Friend                                   00018651BD40 ModelClassType IFriendStatus IFriendStatus IFriendStatus Pointer
    // 018 friendState                              ReactiveProperty`1<FriendState> IL2CPP_TYPE_GENERICINST
    // 020 IdolIcon                                 00018670C7D0 ModelClassType PIdolIcon PIdolIcon PIdolIcon Pointer
    // 028 AchievementIds                           000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    public partial class FriendListViewModel
    {
        public IFriendStatus?                           Friend                                  { get; set; }
        public PIdolIcon?                               IdolIcon                                { get; set; }
        public List<int>?                               AchievementIds                          { get; set; }

        public static FriendListViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FriendListViewModel();

            value.Friend                                    = GetObject<IFriendStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IFriendStatus.FromPointer); // 0270D6332010 0x10 Friend                      ( 00018651BD40 ModelClassType IFriendStatus IFriendStatus IFriendStatus Pointer )
            value.IdolIcon                                  = GetObject<PIdolIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.PIdolIcon.FromPointer); // 0270D6332050 0x20 IdolIcon                    ( 00018670C7D0 ModelClassType PIdolIcon PIdolIcon PIdolIcon Pointer )
            value.AchievementIds                            = GetInt32List(new IntPtr(p + 0x028)); // 0270D6332070 0x28 AchievementIds              ( 000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
