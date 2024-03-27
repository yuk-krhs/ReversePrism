using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SetLiveUnitArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 UnitNumberFieldNumber                    int IL2CPP_TYPE_I4
    // 018 UnitNumber                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 SlotListFieldNumber                      int IL2CPP_TYPE_I4
    // 008 _repeated_slotList_codec                 FieldCodec`1<LiveUnitSlotStatus> IL2CPP_TYPE_GENERICINST
    // 020 SlotList                                 000185CE4778 ModelClassListType RepeatedField`1<LiveUnitSlotStatus> RepeatedField`1<LiveUnitSlotStatus> List<LiveUnitSlotStatus> Pointer
    public partial class SetLiveUnitArgs
    {
        public int                                      UnitNumber                              { get; set; }
        public List<LiveUnitSlotStatus>?                SlotList                                { get; set; }

        public static SetLiveUnitArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SetLiveUnitArgs();

            value.UnitNumber                                = GetInt32(new IntPtr(p + 0x018)); // 0270D21E6300 0x18 UnitNumber                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SlotList                                  = GetObjectList<LiveUnitSlotStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveUnitSlotStatus.FromPointer); // 0270D21E6360 0x20 SlotList                    ( 000185CE4778 ModelClassListType RepeatedField`1<LiveUnitSlotStatus> RepeatedField`1<LiveUnitSlotStatus> List<LiveUnitSlotStatus> Pointer )

            return value;
        }
    }
}
