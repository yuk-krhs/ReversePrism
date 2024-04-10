using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstPotentialLiveSkillID                  0001865F4260 ModelPrimitiveType int int int Int32
    // 014 MstPotentialLiveSkillLevelID             0001865F4260 ModelPrimitiveType int int int Int32
    // 018 Lv                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 020 <Effects>k__BackingField                 ValueTuple`2<string, string>[] IL2CPP_TYPE_SZARRAY
    public partial class PotentialLiveSkillInfoViewModel : DataModel
    {
        public int                                      MstPotentialLiveSkillID                 { get; set; }
        public int                                      MstPotentialLiveSkillLevelID            { get; set; }
        public int                                      Lv                                      { get; set; }

        public static PotentialLiveSkillInfoViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PotentialLiveSkillInfoViewModel() { Pointer= p0 };

            value.MstPotentialLiveSkillID                   = GetInt32(new IntPtr(p + 0x010)); // 024665FEC020 0x10 MstPotentialLiveSkillID     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstPotentialLiveSkillLevelID              = GetInt32(new IntPtr(p + 0x014)); // 024665FEC040 0x14 MstPotentialLiveSkillLevelID ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Lv                                        = GetInt32(new IntPtr(p + 0x018)); // 024665FEC060 0x18 Lv                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
