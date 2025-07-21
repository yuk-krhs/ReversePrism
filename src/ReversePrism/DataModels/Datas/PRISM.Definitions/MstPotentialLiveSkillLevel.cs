using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 MstPotentialLiveSkillId                  ModelPrimitiveType int int int Int32
    // 018 Level                                    ModelPrimitiveType int int int Int32
    // 020 MstLiveSkillEffectIdList                 ModelPrimitiveListType int[] int[] List<int> Pointer
    public partial class MstPotentialLiveSkillLevel : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstPotentialLiveSkillId                 { get; set; }
        public int                                      Level                                   { get; set; }
        public List<int>?                               MstLiveSkillEffectIdList                { get; set; }

        public static MstPotentialLiveSkillLevel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstPotentialLiveSkillLevel() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.MstPotentialLiveSkillId                   = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstPotentialLiveSkillId     ( ModelPrimitiveType int int int Int32 )
            value.Level                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 Level                       ( ModelPrimitiveType int int int Int32 )
            value.MstLiveSkillEffectIdList                  = GetInt32List(new IntPtr(p + 0x020)); // 0x20 MstLiveSkillEffectIdList    ( ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
