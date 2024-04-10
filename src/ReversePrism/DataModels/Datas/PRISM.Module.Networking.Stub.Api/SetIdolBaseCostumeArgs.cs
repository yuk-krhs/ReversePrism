using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SetIdolBaseCostumeArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstIdolIdFieldNumber                     int IL2CPP_TYPE_I4
    // 018 MstIdolId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 SceneTypeFieldNumber                     int IL2CPP_TYPE_I4
    // 01C SceneType                                0001866A53A0 ModelEnumType IdolBaseCostumeTargetSceneType IdolBaseCostumeTargetSceneType IdolBaseCostumeTargetSceneType Int32
    // 000 MstCostumeIdFieldNumber                  int IL2CPP_TYPE_I4
    // 020 MstCostumeId                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstHairstyleIdFieldNumber                int IL2CPP_TYPE_I4
    // 024 MstHairstyleId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstAccessoryIdListFieldNumber            int IL2CPP_TYPE_I4
    // 008 _repeated_mstAccessoryIdList_codec       FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 028 MstAccessoryIdList                       000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 EnableFieldNumber                        int IL2CPP_TYPE_I4
    // 030 Enable                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class SetIdolBaseCostumeArgs : DataModel
    {
        public int                                      MstIdolId                               { get; set; }
        public IdolBaseCostumeTargetSceneType           SceneType                               { get; set; }
        public int                                      MstCostumeId                            { get; set; }
        public int                                      MstHairstyleId                          { get; set; }
        public List<int>?                               MstAccessoryIdList                      { get; set; }
        public bool                                     Enable                                  { get; set; }

        public static SetIdolBaseCostumeArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SetIdolBaseCostumeArgs() { Pointer= p0 };

            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x018)); // 02466206EC40 0x18 MstIdolId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SceneType                                 = (IdolBaseCostumeTargetSceneType)GetInt32(new IntPtr(p + 0x01C)); // 02466206EC80 0x1C SceneType                   ( 0001866A53A0 ModelEnumType IdolBaseCostumeTargetSceneType IdolBaseCostumeTargetSceneType IdolBaseCostumeTargetSceneType Int32 )
            value.MstCostumeId                              = GetInt32(new IntPtr(p + 0x020)); // 02466206ECC0 0x20 MstCostumeId                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstHairstyleId                            = GetInt32(new IntPtr(p + 0x024)); // 02466206ED00 0x24 MstHairstyleId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstAccessoryIdList                        = GetInt32List(new IntPtr(p + 0x028)); // 02466206ED60 0x28 MstAccessoryIdList          ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.Enable                                    = GetBool(new IntPtr(p + 0x030)); // 02466206EDA0 0x30 Enable                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
