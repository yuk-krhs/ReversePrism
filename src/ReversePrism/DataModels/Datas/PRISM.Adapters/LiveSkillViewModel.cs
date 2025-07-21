using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstPotentialLiveSkillID                  ModelPrimitiveType int int int Int32
    // 014 MstPotentialLiveSkillLevelID             ModelPrimitiveType int int int Int32
    // 018 Lv                                       ModelPrimitiveType int int int Int32
    public partial class LiveSkillViewModel : DataModel
    {
        public int                                      MstPotentialLiveSkillID                 { get; set; }
        public int                                      MstPotentialLiveSkillLevelID            { get; set; }
        public int                                      Lv                                      { get; set; }

        public static LiveSkillViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveSkillViewModel() { Pointer= p0 };

            value.MstPotentialLiveSkillID                   = GetInt32(new IntPtr(p + 0x010)); // 0x10 MstPotentialLiveSkillID     ( ModelPrimitiveType int int int Int32 )
            value.MstPotentialLiveSkillLevelID              = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstPotentialLiveSkillLevelID ( ModelPrimitiveType int int int Int32 )
            value.Lv                                        = GetInt32(new IntPtr(p + 0x018)); // 0x18 Lv                          ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
