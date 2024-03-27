using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SkillBufferDisplayStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSkillBufferDisplayIdFieldNumber       int IL2CPP_TYPE_I4
    // 018 MstSkillBufferDisplayId                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstSkillBufferIconIdFieldNumber          int IL2CPP_TYPE_I4
    // 01C MstSkillBufferIconId                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstSkillBufferGroupIdFieldNumber         int IL2CPP_TYPE_I4
    // 020 MstSkillBufferGroupId                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class SkillBufferDisplayStatus
    {
        public int                                      MstSkillBufferDisplayId                 { get; set; }
        public int                                      MstSkillBufferIconId                    { get; set; }
        public int                                      MstSkillBufferGroupId                   { get; set; }

        public static SkillBufferDisplayStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SkillBufferDisplayStatus();

            value.MstSkillBufferDisplayId                   = GetInt32(new IntPtr(p + 0x018)); // 0270D1144940 0x18 MstSkillBufferDisplayId     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstSkillBufferIconId                      = GetInt32(new IntPtr(p + 0x01C)); // 0270D1144980 0x1C MstSkillBufferIconId        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstSkillBufferGroupId                     = GetInt32(new IntPtr(p + 0x020)); // 0270D11449C0 0x20 MstSkillBufferGroupId       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
