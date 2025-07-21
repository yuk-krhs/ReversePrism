using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 MstSkillBufferIconId                     ModelPrimitiveType int int int Int32
    // 018 MstSkillBufferGroupId                    ModelPrimitiveType int int int Int32
    public partial class MstSkillBufferDisplay : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstSkillBufferIconId                    { get; set; }
        public int                                      MstSkillBufferGroupId                   { get; set; }

        public static MstSkillBufferDisplay? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstSkillBufferDisplay() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.MstSkillBufferIconId                      = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstSkillBufferIconId        ( ModelPrimitiveType int int int Int32 )
            value.MstSkillBufferGroupId                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstSkillBufferGroupId       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
