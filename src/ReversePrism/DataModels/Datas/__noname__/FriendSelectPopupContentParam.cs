using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 MstUnitId                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 098 PIdolCharaIds                            000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 0A0 SCharaCharaInfoIds                       000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 0A8 MstSCharaIds                             000185D11ED8 ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer
    // 0B0 FriendSupportList                        IEnumerable`1<IFriendSupportStatus> IL2CPP_TYPE_GENERICINST
    public partial class FriendSelectPopupContentParam
    {
        public int                                      MstUnitId                               { get; set; }
        public List<int>?                               PIdolCharaIds                           { get; set; }
        public List<int>?                               SCharaCharaInfoIds                      { get; set; }
        public List<int>?                               MstSCharaIds                            { get; set; }

        public static FriendSelectPopupContentParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FriendSelectPopupContentParam();

            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x090)); // 0270D5A09730 0x90 MstUnitId                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.PIdolCharaIds                             = GetInt32List(new IntPtr(p + 0x098)); // 0270D5A09750 0x98 PIdolCharaIds               ( 000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SCharaCharaInfoIds                        = GetInt32List(new IntPtr(p + 0x0A0)); // 0270D5A09770 0xA0 SCharaCharaInfoIds          ( 000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.MstSCharaIds                              = GetInt32List(new IntPtr(p + 0x0A8)); // 0270D5A09790 0xA8 MstSCharaIds                ( 000185D11ED8 ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer )

            return value;
        }
    }
}
