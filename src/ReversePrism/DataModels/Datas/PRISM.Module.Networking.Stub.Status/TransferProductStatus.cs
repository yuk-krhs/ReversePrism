using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<TransferProductStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstUnitIdFieldNumber                     int IL2CPP_TYPE_I4
    // 018 MstUnitId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 UnitTransferProductListFieldNumber       int IL2CPP_TYPE_I4
    // 008 _repeated_unitTransferProductList_codec  FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 020 UnitTransferProductList                  000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    // 000 IdolTransferProductListFieldNumber       int IL2CPP_TYPE_I4
    // 010 _repeated_idolTransferProductList_codec  FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 028 IdolTransferProductList                  000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    public partial class TransferProductStatus
    {
        public int                                      MstUnitId                               { get; set; }
        public List<ProductWithAmountStatus>?           UnitTransferProductList                 { get; set; }
        public List<ProductWithAmountStatus>?           IdolTransferProductList                 { get; set; }

        public static TransferProductStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TransferProductStatus();

            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x018)); // 0270D198C230 0x18 MstUnitId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UnitTransferProductList                   = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D198C290 0x20 UnitTransferProductList     ( 000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )
            value.IdolTransferProductList                   = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D198C2F0 0x28 IdolTransferProductList     ( 000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )

            return value;
        }
    }
}
