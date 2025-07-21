using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 MstEventId                               ModelPrimitiveType int int int Int32
    // 018 MstProduceIdolId                         ModelPrimitiveType int int int Int32
    // 01C BaseEffect                               ModelPrimitiveType int int int Int32
    // 020 EffectByStarList                         ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 EffectByLevelList                        ModelPrimitiveListType int[] int[] List<int> Pointer
    public partial class MstLiveEventBonus : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstEventId                              { get; set; }
        public int                                      MstProduceIdolId                        { get; set; }
        public int                                      BaseEffect                              { get; set; }
        public List<int>?                               EffectByStarList                        { get; set; }
        public List<int>?                               EffectByLevelList                       { get; set; }

        public static MstLiveEventBonus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstLiveEventBonus() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.MstEventId                                = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstEventId                  ( ModelPrimitiveType int int int Int32 )
            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstProduceIdolId            ( ModelPrimitiveType int int int Int32 )
            value.BaseEffect                                = GetInt32(new IntPtr(p + 0x01C)); // 0x1C BaseEffect                  ( ModelPrimitiveType int int int Int32 )
            value.EffectByStarList                          = GetInt32List(new IntPtr(p + 0x020)); // 0x20 EffectByStarList            ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.EffectByLevelList                         = GetInt32List(new IntPtr(p + 0x028)); // 0x28 EffectByLevelList           ( ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
