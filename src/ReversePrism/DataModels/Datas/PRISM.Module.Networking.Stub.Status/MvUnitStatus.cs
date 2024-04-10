using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<MvUnitStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 UnitNumberFieldNumber                    int IL2CPP_TYPE_I4
    // 018 UnitNumber                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Name                                     000186671910 ModelPrimitiveType string string string String
    // 000 SlotListFieldNumber                      int IL2CPP_TYPE_I4
    // 008 _repeated_slotList_codec                 FieldCodec`1<MvUnitSlotStatus> IL2CPP_TYPE_GENERICINST
    // 028 SlotList                                 000185CE7A48 ModelClassListType RepeatedField`1<MvUnitSlotStatus> RepeatedField`1<MvUnitSlotStatus> List<MvUnitSlotStatus> Pointer
    public partial class MvUnitStatus : DataModel
    {
        public int                                      UnitNumber                              { get; set; }
        public string                                   Name                                    { get; set; }
        public List<MvUnitSlotStatus>?                  SlotList                                { get; set; }

        public static MvUnitStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MvUnitStatus() { Pointer= p0 };

            value.UnitNumber                                = GetInt32(new IntPtr(p + 0x018)); // 0246612F26B8 0x18 UnitNumber                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 0246612F26F8 0x20 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.SlotList                                  = GetObjectList<MvUnitSlotStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.MvUnitSlotStatus.FromPointer); // 0246612F2758 0x28 SlotList                    ( 000185CE7A48 ModelClassListType RepeatedField`1<MvUnitSlotStatus> RepeatedField`1<MvUnitSlotStatus> List<MvUnitSlotStatus> Pointer )

            return value;
        }
    }
}
