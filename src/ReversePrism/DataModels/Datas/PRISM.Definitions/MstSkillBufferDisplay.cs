using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 MstSkillBufferIconId                     0001865F4260 ModelPrimitiveType int int int Int32
    // 018 MstSkillBufferGroupId                    0001865F4260 ModelPrimitiveType int int int Int32
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

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0245A4713B50 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstSkillBufferIconId                      = GetInt32(new IntPtr(p + 0x014)); // 0245A4713B70 0x14 MstSkillBufferIconId        ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstSkillBufferGroupId                     = GetInt32(new IntPtr(p + 0x018)); // 0245A4713B90 0x18 MstSkillBufferGroupId       ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
