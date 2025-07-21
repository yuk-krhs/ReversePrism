using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ExertSupportEffectStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSupportCharacterIdFieldNumber         int IL2CPP_TYPE_I4
    // 018 MstSupportCharacterId                    ModelPrimitiveType int int int Int32
    // 000 MstSupportEffectIdFieldNumber            int IL2CPP_TYPE_I4
    // 01C MstSupportEffectId                       ModelPrimitiveType int int int Int32
    public partial class ExertSupportEffectStatus : DataModel
    {
        public int                                      MstSupportCharacterId                   { get; set; }
        public int                                      MstSupportEffectId                      { get; set; }

        public static ExertSupportEffectStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExertSupportEffectStatus() { Pointer= p0 };

            value.MstSupportCharacterId                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstSupportCharacterId       ( ModelPrimitiveType int int int Int32 )
            value.MstSupportEffectId                        = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MstSupportEffectId          ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
