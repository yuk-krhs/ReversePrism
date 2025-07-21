using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<LiveUnitSlotStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SlotFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Slot                                     ModelPrimitiveType int int int Int32
    // 000 FesIdolIdFieldNumber                     int IL2CPP_TYPE_I4
    // 020 FesIdolId                                ModelPrimitiveType string string string String
    // 000 MstProduceIdolIdFieldNumber              int IL2CPP_TYPE_I4
    // 028 MstProduceIdolId                         ModelPrimitiveType int int int Int32
    // 000 DressFieldNumber                         int IL2CPP_TYPE_I4
    // 030 Dress                                    ModelClassType DressStatus DressStatus DressStatus Pointer
    public partial class LiveUnitSlotStatus : DataModel
    {
        public int                                      Slot                                    { get; set; }
        public string                                   FesIdolId                               { get; set; }
        public int                                      MstProduceIdolId                        { get; set; }
        public DressStatus?                             Dress                                   { get; set; }

        public static LiveUnitSlotStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitSlotStatus() { Pointer= p0 };

            value.Slot                                      = GetInt32(new IntPtr(p + 0x018)); // 0x18 Slot                        ( ModelPrimitiveType int int int Int32 )
            value.FesIdolId                                 = GetString(new IntPtr(p + 0x020)); // 0x20 FesIdolId                   ( ModelPrimitiveType string string string String )
            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x028)); // 0x28 MstProduceIdolId            ( ModelPrimitiveType int int int Int32 )
            value.Dress                                     = GetObject<DressStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.DressStatus.FromPointer); // 0x30 Dress                       ( ModelClassType DressStatus DressStatus DressStatus Pointer )

            return value;
        }
    }
}
