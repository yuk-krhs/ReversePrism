using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ProduceIdolDressSetStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 UnlockPremiseStarFieldNumber             int IL2CPP_TYPE_I4
    // 018 UnlockPremiseStar                        ModelPrimitiveType int int int Int32
    // 000 MstCostumeSetIdFieldNumber               int IL2CPP_TYPE_I4
    // 01C MstCostumeSetId                          ModelPrimitiveType int int int Int32
    public partial class ProduceIdolDressSetStatus : DataModel
    {
        public int                                      UnlockPremiseStar                       { get; set; }
        public int                                      MstCostumeSetId                         { get; set; }

        public static ProduceIdolDressSetStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceIdolDressSetStatus() { Pointer= p0 };

            value.UnlockPremiseStar                         = GetInt32(new IntPtr(p + 0x018)); // 0x18 UnlockPremiseStar           ( ModelPrimitiveType int int int Int32 )
            value.MstCostumeSetId                           = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MstCostumeSetId             ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
