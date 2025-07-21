using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<TrainingSupportCharacterArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSupportCharacterIdFieldNumber         int IL2CPP_TYPE_I4
    // 018 MstSupportCharacterId                    ModelPrimitiveType int int int Int32
    // 000 UseProductListFieldNumber                int IL2CPP_TYPE_I4
    // 008 _repeated_useProductList_codec           FieldCodec`1<UseProductStatus> IL2CPP_TYPE_GENERICINST
    // 020 UseProductList                           ModelClassListType RepeatedField`1<UseProductStatus> RepeatedField`1<UseProductStatus> List<UseProductStatus> Pointer
    public partial class TrainingSupportCharacterArgs : DataModel
    {
        public int                                      MstSupportCharacterId                   { get; set; }
        public List<UseProductStatus>?                  UseProductList                          { get; set; }

        public static TrainingSupportCharacterArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TrainingSupportCharacterArgs() { Pointer= p0 };

            value.MstSupportCharacterId                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstSupportCharacterId       ( ModelPrimitiveType int int int Int32 )
            value.UseProductList                            = GetObjectList<UseProductStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.UseProductStatus.FromPointer); // 0x20 UseProductList              ( ModelClassListType RepeatedField`1<UseProductStatus> RepeatedField`1<UseProductStatus> List<UseProductStatus> Pointer )

            return value;
        }
    }
}
