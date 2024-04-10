using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<TmpHomeUnitIdolStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 CharacterCostumeFieldNumber              int IL2CPP_TYPE_I4
    // 018 CharacterCostume                         00018659DB60 ModelClassType CharacterCostumeStatus CharacterCostumeStatus CharacterCostumeStatus Pointer
    // 000 SofaMotionTypeFieldNumber                int IL2CPP_TYPE_I4
    // 020 SofaMotionType                           000186525F10 ModelEnumType SofaMotionType SofaMotionType SofaMotionType Int32
    public partial class TmpHomeUnitIdolStatus : DataModel
    {
        public CharacterCostumeStatus?                  CharacterCostume                        { get; set; }
        public SofaMotionType                           SofaMotionType                          { get; set; }

        public static TmpHomeUnitIdolStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TmpHomeUnitIdolStatus() { Pointer= p0 };

            value.CharacterCostume                          = GetObject<CharacterCostumeStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.CharacterCostumeStatus.FromPointer); // 02466202DC40 0x18 CharacterCostume            ( 00018659DB60 ModelClassType CharacterCostumeStatus CharacterCostumeStatus CharacterCostumeStatus Pointer )
            value.SofaMotionType                            = (SofaMotionType)GetInt32(new IntPtr(p + 0x020)); // 02466202DC80 0x20 SofaMotionType              ( 000186525F10 ModelEnumType SofaMotionType SofaMotionType SofaMotionType Int32 )

            return value;
        }
    }
}
