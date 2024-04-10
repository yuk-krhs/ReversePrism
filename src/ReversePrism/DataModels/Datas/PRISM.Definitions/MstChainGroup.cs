using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 GroupType                                0001865F4260 ModelPrimitiveType int int int Int32
    // 018 MstChainUserId                           000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer
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

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0245A46F9060 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.GroupType                                 = GetInt32(new IntPtr(p + 0x014)); // 0245A46F9080 0x14 GroupType                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstChainUserId                            = GetInt32List(new IntPtr(p + 0x018)); // 0245A46F90A0 0x18 MstChainUserId              ( 000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
