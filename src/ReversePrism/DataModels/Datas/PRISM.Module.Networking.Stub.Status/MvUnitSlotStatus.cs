using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<MvUnitSlotStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SlotFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Slot                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 IdolFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Idol                                     0001866788A0 ModelClassType MvIdolStatus MvIdolStatus MvIdolStatus Pointer
    public partial class MvUnitSlotStatus
    {
        public int                                      Slot                                    { get; set; }
        public MvIdolStatus?                            Idol                                    { get; set; }

        public static MvUnitSlotStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MvUnitSlotStatus();

            value.Slot                                      = GetInt32(new IntPtr(p + 0x018)); // 0270D13686C8 0x18 Slot                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Idol                                      = GetObject<MvIdolStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.MvIdolStatus.FromPointer); // 0270D1368708 0x20 Idol                        ( 0001866788A0 ModelClassType MvIdolStatus MvIdolStatus MvIdolStatus Pointer )

            return value;
        }
    }
}
