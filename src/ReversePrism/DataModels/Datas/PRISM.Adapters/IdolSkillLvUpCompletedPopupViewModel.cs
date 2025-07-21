using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PIdolIcon                                ModelClassType PIdolIcon PIdolIcon PIdolIcon Pointer
    // 018 MstPIdolId                               ModelPrimitiveType int int int Int32
    // 01C MstIdolId                                ModelPrimitiveType int int int Int32
    // 020 IdolSkills                               ModelClassListType List`1<IdolSkillContentViewModel> List`1<IdolSkillContentViewModel> List<IdolSkillContentViewModel> Pointer
    // 028 BeforeSkillLv                            ModelPrimitiveType int int int Int32
    // 02C AfterSkillLv                             ModelPrimitiveType int int int Int32
    // 030 CueSheetName                             ModelPrimitiveType string string string String
    // 038 CueName                                  ModelPrimitiveType string string string String
    public partial class IdolSkillLvUpCompletedPopupViewModel : DataModel
    {
        public PIdolIcon?                               PIdolIcon                               { get; set; }
        public int                                      MstPIdolId                              { get; set; }
        public int                                      MstIdolId                               { get; set; }
        public List<IdolSkillContentViewModel>?         IdolSkills                              { get; set; }
        public int                                      BeforeSkillLv                           { get; set; }
        public int                                      AfterSkillLv                            { get; set; }
        public string                                   CueSheetName                            { get; set; }
        public string                                   CueName                                 { get; set; }

        public static IdolSkillLvUpCompletedPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolSkillLvUpCompletedPopupViewModel() { Pointer= p0 };

            value.PIdolIcon                                 = GetObject<PIdolIcon>(new IntPtr(p + 0x010), ReversePrism.DataModels.PIdolIcon.FromPointer); // 0x10 PIdolIcon                   ( ModelClassType PIdolIcon PIdolIcon PIdolIcon Pointer )
            value.MstPIdolId                                = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstPIdolId                  ( ModelPrimitiveType int int int Int32 )
            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MstIdolId                   ( ModelPrimitiveType int int int Int32 )
            value.IdolSkills                                = GetObjectList<IdolSkillContentViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.IdolSkillContentViewModel.FromPointer); // 0x20 IdolSkills                  ( ModelClassListType List`1<IdolSkillContentViewModel> List`1<IdolSkillContentViewModel> List<IdolSkillContentViewModel> Pointer )
            value.BeforeSkillLv                             = GetInt32(new IntPtr(p + 0x028)); // 0x28 BeforeSkillLv               ( ModelPrimitiveType int int int Int32 )
            value.AfterSkillLv                              = GetInt32(new IntPtr(p + 0x02C)); // 0x2C AfterSkillLv                ( ModelPrimitiveType int int int Int32 )
            value.CueSheetName                              = GetString(new IntPtr(p + 0x030)); // 0x30 CueSheetName                ( ModelPrimitiveType string string string String )
            value.CueName                                   = GetString(new IntPtr(p + 0x038)); // 0x38 CueName                     ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
