using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<DressStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstDressIdFieldNumber                    int IL2CPP_TYPE_I4
    // 018 MstDressId                               ModelPrimitiveType int int int Int32
    // 000 MstAccessoryIdListFieldNumber            int IL2CPP_TYPE_I4
    // 008 _repeated_mstAccessoryIdList_codec       FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 020 MstAccessoryIdList                       ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 MstHairStyleIdFieldNumber                int IL2CPP_TYPE_I4
    // 028 MstHairStyleId                           ModelPrimitiveType int int int Int32
    public partial class DressStatus : DataModel
    {
        public int                                      MstDressId                              { get; set; }
        public List<int>?                               MstAccessoryIdList                      { get; set; }
        public int                                      MstHairStyleId                          { get; set; }

        public static DressStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DressStatus() { Pointer= p0 };

            value.MstDressId                                = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstDressId                  ( ModelPrimitiveType int int int Int32 )
            value.MstAccessoryIdList                        = GetInt32List(new IntPtr(p + 0x020)); // 0x20 MstAccessoryIdList          ( ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.MstHairStyleId                            = GetInt32(new IntPtr(p + 0x028)); // 0x28 MstHairStyleId              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
