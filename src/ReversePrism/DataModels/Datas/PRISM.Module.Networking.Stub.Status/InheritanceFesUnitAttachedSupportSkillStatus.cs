using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<InheritanceFesUnitAttachedSupportSkillStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSupportSkillIdFieldNumber             int IL2CPP_TYPE_I4
    // 018 MstSupportSkillId                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 LevelFieldNumber                         int IL2CPP_TYPE_I4
    // 01C Level                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 IsInheritedFieldNumber                   int IL2CPP_TYPE_I4
    // 020 IsInherited                              000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class InheritanceFesUnitAttachedSupportSkillStatus
    {
        public int                                      MstSupportSkillId                       { get; set; }
        public int                                      Level                                   { get; set; }
        public bool                                     IsInherited                             { get; set; }

        public static InheritanceFesUnitAttachedSupportSkillStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InheritanceFesUnitAttachedSupportSkillStatus();

            value.MstSupportSkillId                         = GetInt32(new IntPtr(p + 0x018)); // 0270D10E71D0 0x18 MstSupportSkillId           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Level                                     = GetInt32(new IntPtr(p + 0x01C)); // 0270D10E7210 0x1C Level                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsInherited                               = GetBool(new IntPtr(p + 0x020)); // 0270D10E7250 0x20 IsInherited                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
