using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<IdolLevelRewardStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 IdolLevelFieldNumber                     int IL2CPP_TYPE_I4
    // 018 IdolLevel                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ParameterFieldNumber                     int IL2CPP_TYPE_I4
    // 020 Parameter                                0001866B60B0 ModelClassType IdolParameterStatus IdolParameterStatus IdolParameterStatus Pointer
    // 000 ProductWithAmountListFieldNumber         int IL2CPP_TYPE_I4
    // 008 _repeated_productWithAmountList_codec    FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 028 ProductWithAmountList                    000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    // 000 IsArchivedFieldNumber                    int IL2CPP_TYPE_I4
    // 030 IsArchived                               000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class IdolLevelRewardStatus : DataModel
    {
        public int                                      IdolLevel                               { get; set; }
        public IdolParameterStatus?                     Parameter                               { get; set; }
        public List<ProductWithAmountStatus>?           ProductWithAmountList                   { get; set; }
        public bool                                     IsArchived                              { get; set; }

        public static IdolLevelRewardStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolLevelRewardStatus() { Pointer= p0 };

            value.IdolLevel                                 = GetInt32(new IntPtr(p + 0x018)); // 024661CA6000 0x18 IdolLevel                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Parameter                                 = GetObject<IdolParameterStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IdolParameterStatus.FromPointer); // 024661CA6040 0x20 Parameter                   ( 0001866B60B0 ModelClassType IdolParameterStatus IdolParameterStatus IdolParameterStatus Pointer )
            value.ProductWithAmountList                     = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 024661CA60A0 0x28 ProductWithAmountList       ( 000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )
            value.IsArchived                                = GetBool(new IntPtr(p + 0x030)); // 024661CA60E0 0x30 IsArchived                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
