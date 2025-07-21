using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LiveSkillLevels                          ModelClassListType IReadOnlyList`1<IPotentialLiveSkillLevelStatus> IReadOnlyList`1<IPotentialLiveSkillLevelStatus> List<IPotentialLiveSkillLevelStatus> Pointer
    // 018 onUpdate                                 Subject`1<PotentialLiveSkillInfoViewModel> IL2CPP_TYPE_GENERICINST
    // 020 MstPotentialLiveSkillID                  ModelPrimitiveType int int int Int32
    // 024 MstPotentialLiveSkillLevelID             ModelPrimitiveType int int int Int32
    // 028 Lv                                       ModelPrimitiveType int int int Int32
    // 030 <Effects>k__BackingField                 ValueTuple`2<string, string>[] IL2CPP_TYPE_SZARRAY
    public partial class PotentialLiveSkillInfoViewModel : DataModel
    {
        public List<IPotentialLiveSkillLevelStatus>?    LiveSkillLevels                         { get; set; }
        public int                                      MstPotentialLiveSkillID                 { get; set; }
        public int                                      MstPotentialLiveSkillLevelID            { get; set; }
        public int                                      Lv                                      { get; set; }

        public static PotentialLiveSkillInfoViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PotentialLiveSkillInfoViewModel() { Pointer= p0 };

            value.LiveSkillLevels                           = GetObjectList<IPotentialLiveSkillLevelStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IPotentialLiveSkillLevelStatus.FromPointer); // 0x10 LiveSkillLevels             ( ModelClassListType IReadOnlyList`1<IPotentialLiveSkillLevelStatus> IReadOnlyList`1<IPotentialLiveSkillLevelStatus> List<IPotentialLiveSkillLevelStatus> Pointer )
            value.MstPotentialLiveSkillID                   = GetInt32(new IntPtr(p + 0x020)); // 0x20 MstPotentialLiveSkillID     ( ModelPrimitiveType int int int Int32 )
            value.MstPotentialLiveSkillLevelID              = GetInt32(new IntPtr(p + 0x024)); // 0x24 MstPotentialLiveSkillLevelID ( ModelPrimitiveType int int int Int32 )
            value.Lv                                        = GetInt32(new IntPtr(p + 0x028)); // 0x28 Lv                          ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
