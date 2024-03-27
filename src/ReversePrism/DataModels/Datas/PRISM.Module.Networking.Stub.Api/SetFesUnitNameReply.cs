using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SetFesUnitNameReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 FesUnitFieldNumber                       int IL2CPP_TYPE_I4
    // 018 FesUnit                                  00018656E120 ModelClassType FesUnitStatus FesUnitStatus FesUnitStatus Pointer
    // 000 FesIdolListFieldNumber                   int IL2CPP_TYPE_I4
    // 008 _repeated_fesIdolList_codec              FieldCodec`1<FesIdolStatus> IL2CPP_TYPE_GENERICINST
    // 020 FesIdolList                              000185CD7D58 ModelClassListType RepeatedField`1<FesIdolStatus> RepeatedField`1<FesIdolStatus> List<FesIdolStatus> Pointer
    public partial class SetFesUnitNameReply
    {
        public FesUnitStatus?                           FesUnit                                 { get; set; }
        public List<FesIdolStatus>?                     FesIdolList                             { get; set; }

        public static SetFesUnitNameReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SetFesUnitNameReply();

            value.FesUnit                                   = GetObject<FesUnitStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.FesUnitStatus.FromPointer); // 0270D13250B0 0x18 FesUnit                     ( 00018656E120 ModelClassType FesUnitStatus FesUnitStatus FesUnitStatus Pointer )
            value.FesIdolList                               = GetObjectList<FesIdolStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.FesIdolStatus.FromPointer); // 0270D1325110 0x20 FesIdolList                 ( 000185CD7D58 ModelClassListType RepeatedField`1<FesIdolStatus> RepeatedField`1<FesIdolStatus> List<FesIdolStatus> Pointer )

            return value;
        }
    }
}
