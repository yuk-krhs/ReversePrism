using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NewDressTrainingLevel                    000185B78FA0 ModelPrimitiveListType bool[] bool[] List<bool> Pointer
    // 018 CurrentIdolSkillLv                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C CurrentPotentialLiveSkillLv              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 IdolSkillLvAfter                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 PotentialLiveSkillLvAfter                0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class OtherBonusViewModel : DataModel
    {
        public List<bool>?                              NewDressTrainingLevel                   { get; set; }
        public int                                      CurrentIdolSkillLv                      { get; set; }
        public int                                      CurrentPotentialLiveSkillLv             { get; set; }
        public int                                      IdolSkillLvAfter                        { get; set; }
        public int                                      PotentialLiveSkillLvAfter               { get; set; }

        public static OtherBonusViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OtherBonusViewModel() { Pointer= p0 };

            value.NewDressTrainingLevel                     = GetBoolList(new IntPtr(p + 0x010)); // 024666041600 0x10 NewDressTrainingLevel       ( 000185B78FA0 ModelPrimitiveListType bool[] bool[] List<bool> Pointer )
            value.CurrentIdolSkillLv                        = GetInt32(new IntPtr(p + 0x018)); // 024666041620 0x18 CurrentIdolSkillLv          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentPotentialLiveSkillLv               = GetInt32(new IntPtr(p + 0x01C)); // 024666041640 0x1C CurrentPotentialLiveSkillLv ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IdolSkillLvAfter                          = GetInt32(new IntPtr(p + 0x020)); // 024666041660 0x20 IdolSkillLvAfter            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PotentialLiveSkillLvAfter                 = GetInt32(new IntPtr(p + 0x024)); // 024666041680 0x24 PotentialLiveSkillLvAfter   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
