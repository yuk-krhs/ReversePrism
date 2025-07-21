using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 MstProducePassiveEffectTypeId            ModelPrimitiveType int int int Int32
    // 018 ValueList                                ModelPrimitiveListType int[] int[] List<int> Pointer
    public partial class MstProducePassiveEffect : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstProducePassiveEffectTypeId           { get; set; }
        public List<int>?                               ValueList                               { get; set; }

        public static MstProducePassiveEffect? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstProducePassiveEffect() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.MstProducePassiveEffectTypeId             = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstProducePassiveEffectTypeId ( ModelPrimitiveType int int int Int32 )
            value.ValueList                                 = GetInt32List(new IntPtr(p + 0x018)); // 0x18 ValueList                   ( ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
