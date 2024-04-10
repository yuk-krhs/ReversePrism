using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<DearnessLevelRewardStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 DearnessLevelFieldNumber                 int IL2CPP_TYPE_I4
    // 018 DearnessLevel                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ProductWithAmountListFieldNumber         int IL2CPP_TYPE_I4
    // 008 _repeated_productWithAmountList_codec    FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 020 ProductWithAmountList                    000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    // 000 IsArchivedFieldNumber                    int IL2CPP_TYPE_I4
    // 028 IsArchived                               000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class DearnessLevelRewardStatus : DataModel
    {
        public int                                      DearnessLevel                           { get; set; }
        public List<ProductWithAmountStatus>?           ProductWithAmountList                   { get; set; }
        public bool                                     IsArchived                              { get; set; }

        public static DearnessLevelRewardStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DearnessLevelRewardStatus() { Pointer= p0 };

            value.DearnessLevel                             = GetInt32(new IntPtr(p + 0x018)); // 024661C9FBC0 0x18 DearnessLevel               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ProductWithAmountList                     = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 024661C9FC20 0x20 ProductWithAmountList       ( 000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )
            value.IsArchived                                = GetBool(new IntPtr(p + 0x028)); // 024661C9FC60 0x28 IsArchived                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
