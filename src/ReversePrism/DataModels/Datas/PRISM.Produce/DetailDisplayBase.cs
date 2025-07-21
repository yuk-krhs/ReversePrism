using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 NameText                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 DescriptionText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 CacheBaseIngameSkillDetailKeywordContent ModelClassType BaseIngameSkillDetailKeywordContent BaseIngameSkillDetailKeywordContent BaseIngameSkillDetailKeywordContent Pointer
    // 038 TempLinkInfos                            ModelEnumListType List`1<TMP_LinkInfo> List`1<TMP_LinkInfo> List<TMP_LinkInfo> Pointer
    // 040 TempLinkIDs                              ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    public partial class DetailDisplayBase : DataModel
    {
        public UITextMeshProUGUI?                       NameText                                { get; set; }
        public UITextMeshProUGUI?                       DescriptionText                         { get; set; }
        public BaseIngameSkillDetailKeywordContent?     CacheBaseIngameSkillDetailKeywordContent { get; set; }
        public List<TMP_LinkInfo>?                      TempLinkInfos                           { get; set; }
        public List<string>?                            TempLinkIDs                             { get; set; }

        public static DetailDisplayBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DetailDisplayBase() { Pointer= p0 };

            value.NameText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 NameText                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DescriptionText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 DescriptionText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CacheBaseIngameSkillDetailKeywordContent  = GetObject<BaseIngameSkillDetailKeywordContent>(new IntPtr(p + 0x030), ReversePrism.DataModels.BaseIngameSkillDetailKeywordContent.FromPointer); // 0x30 CacheBaseIngameSkillDetailKeywordContent ( ModelClassType BaseIngameSkillDetailKeywordContent BaseIngameSkillDetailKeywordContent BaseIngameSkillDetailKeywordContent Pointer )
            value.TempLinkInfos                             = GetEnumList<TMP_LinkInfo>(new IntPtr(p + 0x038)); // 0x38 TempLinkInfos               ( ModelEnumListType List`1<TMP_LinkInfo> List`1<TMP_LinkInfo> List<TMP_LinkInfo> Pointer )
            value.TempLinkIDs                               = GetStringList(new IntPtr(p + 0x040)); // 0x40 TempLinkIDs                 ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )

            return value;
        }
    }
}
