using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SupportCharacterIconStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstCharacterInfoIdFieldNumber            int IL2CPP_TYPE_I4
    // 018 MstCharacterInfoId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 IsCooperationEventFieldNumber            int IL2CPP_TYPE_I4
    // 01C IsCooperationEvent                       000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class SupportCharacterIconStatus
    {
        public int                                      MstCharacterInfoId                      { get; set; }
        public bool                                     IsCooperationEvent                      { get; set; }

        public static SupportCharacterIconStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharacterIconStatus();

            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x018)); // 0270D1159B48 0x18 MstCharacterInfoId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsCooperationEvent                        = GetBool(new IntPtr(p + 0x01C)); // 0270D1159B88 0x1C IsCooperationEvent          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
