using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<IdolBaseCostumeStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 CostumeFieldNumber                       int IL2CPP_TYPE_I4
    // 018 Costume                                  ModelClassType DressStatus DressStatus DressStatus Pointer
    // 000 SceneTypeFieldNumber                     int IL2CPP_TYPE_I4
    // 020 SceneType                                ModelEnumType IdolBaseCostumeTargetSceneType IdolBaseCostumeTargetSceneType IdolBaseCostumeTargetSceneType Int32
    // 000 EnableFieldNumber                        int IL2CPP_TYPE_I4
    // 024 Enable                                   ModelPrimitiveType bool bool bool Bool
    public partial class IdolBaseCostumeStatus : DataModel
    {
        public DressStatus?                             Costume                                 { get; set; }
        public IdolBaseCostumeTargetSceneType           SceneType                               { get; set; }
        public bool                                     Enable                                  { get; set; }

        public static IdolBaseCostumeStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolBaseCostumeStatus() { Pointer= p0 };

            value.Costume                                   = GetObject<DressStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.DressStatus.FromPointer); // 0x18 Costume                     ( ModelClassType DressStatus DressStatus DressStatus Pointer )
            value.SceneType                                 = (IdolBaseCostumeTargetSceneType)GetInt32(new IntPtr(p + 0x020)); // 0x20 SceneType                   ( ModelEnumType IdolBaseCostumeTargetSceneType IdolBaseCostumeTargetSceneType IdolBaseCostumeTargetSceneType Int32 )
            value.Enable                                    = GetBool(new IntPtr(p + 0x024)); // 0x24 Enable                      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
