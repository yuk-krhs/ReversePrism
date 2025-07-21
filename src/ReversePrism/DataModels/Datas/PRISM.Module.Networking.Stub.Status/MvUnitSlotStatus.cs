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
    // 018 Slot                                     ModelPrimitiveType int int int Int32
    // 000 IdolFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Idol                                     ModelClassType MvIdolStatus MvIdolStatus MvIdolStatus Pointer
    public partial class MvUnitSlotStatus : DataModel
    {
        public int                                      Slot                                    { get; set; }
        public MvIdolStatus?                            Idol                                    { get; set; }

        public static MvUnitSlotStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MvUnitSlotStatus() { Pointer= p0 };

            value.Slot                                      = GetInt32(new IntPtr(p + 0x018)); // 0x18 Slot                        ( ModelPrimitiveType int int int Int32 )
            value.Idol                                      = GetObject<MvIdolStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.MvIdolStatus.FromPointer); // 0x20 Idol                        ( ModelClassType MvIdolStatus MvIdolStatus MvIdolStatus Pointer )

            return value;
        }
    }
}
