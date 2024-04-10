using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Data                                     00018651C270 ModelClassType IFriendSupportStatus IFriendSupportStatus IFriendSupportStatus Pointer
    // 018 SCharaIcon                               0001866A9EE0 ModelClassType SCharaIcon SCharaIcon SCharaIcon Pointer
    public partial class FriendSupportModel : DataModel
    {
        public IFriendSupportStatus?                    Data                                    { get; set; }
        public SCharaIcon?                              SCharaIcon                              { get; set; }

        public static FriendSupportModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FriendSupportModel() { Pointer= p0 };

            value.Data                                      = GetObject<IFriendSupportStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IFriendSupportStatus.FromPointer); // 0246654E5800 0x10 Data                        ( 00018651C270 ModelClassType IFriendSupportStatus IFriendSupportStatus IFriendSupportStatus Pointer )
            value.SCharaIcon                                = GetObject<SCharaIcon>(new IntPtr(p + 0x018), ReversePrism.DataModels.SCharaIcon.FromPointer); // 0246654E5820 0x18 SCharaIcon                  ( 0001866A9EE0 ModelClassType SCharaIcon SCharaIcon SCharaIcon Pointer )

            return value;
        }
    }
}
