using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<IdolBaseStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 IdolBaseIdFieldNumber                    int IL2CPP_TYPE_I4
    // 018 IdolBaseId                               000186671910 ModelPrimitiveType string string string String
    // 000 MstIdolIdFieldNumber                     int IL2CPP_TYPE_I4
    // 020 MstIdolId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ParameterFieldNumber                     int IL2CPP_TYPE_I4
    // 028 Parameter                                0001866B60B0 ModelClassType IdolParameterStatus IdolParameterStatus IdolParameterStatus Pointer
    // 000 FanFieldNumber                           int IL2CPP_TYPE_I4
    // 030 Fan                                      0001865F7700 ModelPrimitiveType long long long Int64
    // 000 IdolLevelFieldNumber                     int IL2CPP_TYPE_I4
    // 038 IdolLevel                                00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 IdolLevelExpFieldNumber                  int IL2CPP_TYPE_I4
    // 040 IdolLevelExp                             00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 DearnessLevelFieldNumber                 int IL2CPP_TYPE_I4
    // 048 DearnessLevel                            00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 DearnessLevelExpFieldNumber              int IL2CPP_TYPE_I4
    // 050 DearnessLevelExp                         00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 CostumeListFieldNumber                   int IL2CPP_TYPE_I4
    // 008 _repeated_costumeList_codec              FieldCodec`1<IdolBaseCostumeStatus> IL2CPP_TYPE_GENERICINST
    // 058 CostumeList                              000185CDEF68 ModelClassListType RepeatedField`1<IdolBaseCostumeStatus> RepeatedField`1<IdolBaseCostumeStatus> List<IdolBaseCostumeStatus> Pointer
    public partial class IdolBaseStatus : DataModel
    {
        public string                                   IdolBaseId                              { get; set; }
        public int                                      MstIdolId                               { get; set; }
        public IdolParameterStatus?                     Parameter                               { get; set; }
        public long                                     Fan                                     { get; set; }
        public LimitedValueStatus?                      IdolLevel                               { get; set; }
        public LimitedValueStatus?                      IdolLevelExp                            { get; set; }
        public LimitedValueStatus?                      DearnessLevel                           { get; set; }
        public LimitedValueStatus?                      DearnessLevelExp                        { get; set; }
        public List<IdolBaseCostumeStatus>?             CostumeList                             { get; set; }

        public static IdolBaseStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolBaseStatus() { Pointer= p0 };

            value.IdolBaseId                                = GetString(new IntPtr(p + 0x018)); // 024661CA4DA8 0x18 IdolBaseId                  ( 000186671910 ModelPrimitiveType string string string String )
            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x020)); // 024661CA4DE8 0x20 MstIdolId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Parameter                                 = GetObject<IdolParameterStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IdolParameterStatus.FromPointer); // 024661CA4E28 0x28 Parameter                   ( 0001866B60B0 ModelClassType IdolParameterStatus IdolParameterStatus IdolParameterStatus Pointer )
            value.Fan                                       = GetInt64(new IntPtr(p + 0x030)); // 024661CA4E68 0x30 Fan                         ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.IdolLevel                                 = GetObject<LimitedValueStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 024661CA4EA8 0x38 IdolLevel                   ( 00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value.IdolLevelExp                              = GetObject<LimitedValueStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 024661CA4EE8 0x40 IdolLevelExp                ( 00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value.DearnessLevel                             = GetObject<LimitedValueStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 024661CA4F28 0x48 DearnessLevel               ( 00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value.DearnessLevelExp                          = GetObject<LimitedValueStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 024661CA4F68 0x50 DearnessLevelExp            ( 00018652EBE0 ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value.CostumeList                               = GetObjectList<IdolBaseCostumeStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.IdolBaseCostumeStatus.FromPointer); // 024661CA4FC8 0x58 CostumeList                 ( 000185CDEF68 ModelClassListType RepeatedField`1<IdolBaseCostumeStatus> RepeatedField`1<IdolBaseCostumeStatus> List<IdolBaseCostumeStatus> Pointer )

            return value;
        }
    }
}
