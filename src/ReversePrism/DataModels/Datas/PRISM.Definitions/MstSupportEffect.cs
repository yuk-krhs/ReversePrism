using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 EffectId                                 0001865F4260 ModelPrimitiveType int int int Int32
    // 018 MstProducePassiveEffectIdList            000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 020 EntrustAppealType                        0001865F4260 ModelPrimitiveType int int int Int32
    // 024 EntrustScore                             0001865F4260 ModelPrimitiveType int int int Int32
    // 028 ChoiceWeight                             0001865F4260 ModelPrimitiveType int int int Int32
    public partial class MstSupportEffect : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      EffectId                                { get; set; }
        public List<int>?                               MstProducePassiveEffectIdList           { get; set; }
        public int                                      EntrustAppealType                       { get; set; }
        public int                                      EntrustScore                            { get; set; }
        public int                                      ChoiceWeight                            { get; set; }

        public static MstSupportEffect? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstSupportEffect() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0245A46B67D0 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.EffectId                                  = GetInt32(new IntPtr(p + 0x014)); // 0245A46B67F0 0x14 EffectId                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstProducePassiveEffectIdList             = GetInt32List(new IntPtr(p + 0x018)); // 0245A46B6810 0x18 MstProducePassiveEffectIdList ( 000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.EntrustAppealType                         = GetInt32(new IntPtr(p + 0x020)); // 0245A46B6830 0x20 EntrustAppealType           ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.EntrustScore                              = GetInt32(new IntPtr(p + 0x024)); // 0245A46B6850 0x24 EntrustScore                ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ChoiceWeight                              = GetInt32(new IntPtr(p + 0x028)); // 0245A46B6870 0x28 ChoiceWeight                ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
