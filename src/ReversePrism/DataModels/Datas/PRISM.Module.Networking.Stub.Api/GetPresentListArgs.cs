using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PresentFilterTypeList                    000185D187C8 ModelEnumListType IReadOnlyList`1<PresentFilterType> IReadOnlyList`1<PresentFilterType> List<PresentFilterType> Pointer
    // 000 _parser                                  MessageParser`1<GetPresentListArgs> IL2CPP_TYPE_GENERICINST
    // 018 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 CursorFieldNumber                        int IL2CPP_TYPE_I4
    // 020 Cursor                                   000186671910 ModelPrimitiveType string string string String
    // 000 LimitFieldNumber                         int IL2CPP_TYPE_I4
    // 028 Limit                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 IsSortAscFieldNumber                     int IL2CPP_TYPE_I4
    // 02C IsSortAsc                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 PresentEndDateTypeFieldNumber            int IL2CPP_TYPE_I4
    // 030 PresentEndDateType                       00018650B7A0 ModelEnumType PresentEndDateType PresentEndDateType PresentEndDateType Int32
    // 000 PresentFilterTypeListFieldNumber         int IL2CPP_TYPE_I4
    // 008 _repeated_presentFilterTypeList_codec    FieldCodec`1<PresentFilterType> IL2CPP_TYPE_GENERICINST
    // 038 PresentFilterTypeList                    000185CE97D8 ModelEnumListType RepeatedField`1<PresentFilterType> RepeatedField`1<PresentFilterType> List<PresentFilterType> Pointer
    public partial class GetPresentListArgs : DataModel
    {
        public List<PresentFilterType>?                 PresentFilterTypeList                   { get; set; }
        public string                                   Cursor                                  { get; set; }
        public int                                      Limit                                   { get; set; }
        public bool                                     IsSortAsc                               { get; set; }
        public PresentEndDateType                       PresentEndDateType                      { get; set; }

        public static GetPresentListArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetPresentListArgs() { Pointer= p0 };

            value.PresentFilterTypeList                     = GetEnumList<PresentFilterType>(new IntPtr(p + 0x038)); // 0246623F6418 0x38 PresentFilterTypeList       ( 000185CE97D8 ModelEnumListType RepeatedField`1<PresentFilterType> RepeatedField`1<PresentFilterType> List<PresentFilterType> Pointer )
            value.Cursor                                    = GetString(new IntPtr(p + 0x020)); // 0246623F62F8 0x20 Cursor                      ( 000186671910 ModelPrimitiveType string string string String )
            value.Limit                                     = GetInt32(new IntPtr(p + 0x028)); // 0246623F6338 0x28 Limit                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsSortAsc                                 = GetBool(new IntPtr(p + 0x02C)); // 0246623F6378 0x2C IsSortAsc                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PresentEndDateType                        = (PresentEndDateType)GetInt32(new IntPtr(p + 0x030)); // 0246623F63B8 0x30 PresentEndDateType          ( 00018650B7A0 ModelEnumType PresentEndDateType PresentEndDateType PresentEndDateType Int32 )

            return value;
        }
    }
}
