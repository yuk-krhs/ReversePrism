using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 MstPotentialLiveSkillId                  0001865F4260 ModelPrimitiveType int int int Int32
    // 018 Level                                    0001865F4260 ModelPrimitiveType int int int Int32
    // 020 MstLiveSkillEffectIdList                 000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer
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

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0245A4656C50 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstPotentialLiveSkillId                   = GetInt32(new IntPtr(p + 0x014)); // 0245A4656C70 0x14 MstPotentialLiveSkillId     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Level                                     = GetInt32(new IntPtr(p + 0x018)); // 0245A4656C90 0x18 Level                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstLiveSkillEffectIdList                  = GetInt32List(new IntPtr(p + 0x020)); // 0245A4656CB0 0x20 MstLiveSkillEffectIdList    ( 000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
