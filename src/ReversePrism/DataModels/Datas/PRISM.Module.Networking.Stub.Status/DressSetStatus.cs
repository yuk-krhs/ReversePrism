using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<DressSetStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstDressSetIdFieldNumber                 int IL2CPP_TYPE_I4
    // 018 MstDressSetId                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ProductListFieldNumber                   int IL2CPP_TYPE_I4
    // 008 _repeated_productList_codec              FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 020 ProductList                              000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    public partial class DressSetStatus
    {
        public int                                      MstDressSetId                           { get; set; }
        public List<ProductWithAmountStatus>?           ProductList                             { get; set; }

        public static DressSetStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DressSetStatus();

            value.MstDressSetId                             = GetInt32(new IntPtr(p + 0x018)); // 0270D3749140 0x18 MstDressSetId               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ProductList                               = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D37491A0 0x20 ProductList                 ( 000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )

            return value;
        }
    }
}
