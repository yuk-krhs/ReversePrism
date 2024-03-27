using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<LiveUnitSlotDetailStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SlotFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Slot                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 UnitIdolFieldNumber                      int IL2CPP_TYPE_I4
    // 020 UnitIdol                                 000186592F90 ModelClassType LiveUnitIdolDetailStatus LiveUnitIdolDetailStatus LiveUnitIdolDetailStatus Pointer
    public partial class LiveUnitSlotDetailStatus
    {
        public int                                      Slot                                    { get; set; }
        public LiveUnitIdolDetailStatus?                UnitIdol                                { get; set; }

        public static LiveUnitSlotDetailStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitSlotDetailStatus();

            value.Slot                                      = GetInt32(new IntPtr(p + 0x018)); // 0270D1364B90 0x18 Slot                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UnitIdol                                  = GetObject<LiveUnitIdolDetailStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveUnitIdolDetailStatus.FromPointer); // 0270D1364BD0 0x20 UnitIdol                    ( 000186592F90 ModelClassType LiveUnitIdolDetailStatus LiveUnitIdolDetailStatus LiveUnitIdolDetailStatus Pointer )

            return value;
        }
    }
}
