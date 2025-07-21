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
    // 018 MstSkillBufferDisplayId                  ModelPrimitiveType int int int Int32
    // 000 MstSkillBufferIconIdFieldNumber          int IL2CPP_TYPE_I4
    // 01C MstSkillBufferIconId                     ModelPrimitiveType int int int Int32
    // 000 MstSkillBufferGroupIdFieldNumber         int IL2CPP_TYPE_I4
    // 020 MstSkillBufferGroupId                    ModelPrimitiveType int int int Int32
    public partial class SkillBufferDisplayStatus : DataModel
    {
        public int                                      MstSkillBufferDisplayId                 { get; set; }
        public int                                      MstSkillBufferIconId                    { get; set; }
        public int                                      MstSkillBufferGroupId                   { get; set; }

        public static SkillBufferDisplayStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SkillBufferDisplayStatus() { Pointer= p0 };

            value.MstSkillBufferDisplayId                   = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstSkillBufferDisplayId     ( ModelPrimitiveType int int int Int32 )
            value.MstSkillBufferIconId                      = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MstSkillBufferIconId        ( ModelPrimitiveType int int int Int32 )
            value.MstSkillBufferGroupId                     = GetInt32(new IntPtr(p + 0x020)); // 0x20 MstSkillBufferGroupId       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
