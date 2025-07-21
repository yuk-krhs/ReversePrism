using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 GroupType                                ModelPrimitiveType int int int Int32
    // 018 MstChainUserId                           ModelPrimitiveListType int[] int[] List<int> Pointer
    public partial class MstChainGroup : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      GroupType                               { get; set; }
        public List<int>?                               MstChainUserId                          { get; set; }

        public static MstChainGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstChainGroup() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.GroupType                                 = GetInt32(new IntPtr(p + 0x014)); // 0x14 GroupType                   ( ModelPrimitiveType int int int Int32 )
            value.MstChainUserId                            = GetInt32List(new IntPtr(p + 0x018)); // 0x18 MstChainUserId              ( ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
