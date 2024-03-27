using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 NameText                                 0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 DescriptionText                          0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 CacheBaseIngameSkillDetailKeywordContent 00018673EBE0 ModelClassType BaseIngameSkillDetailKeywordContent BaseIngameSkillDetailKeywordContent BaseIngameSkillDetailKeywordContent Pointer
    // 038 TempLinkInfos                            000185D12428 ModelEnumListType List`1<TMP_LinkInfo> List`1<TMP_LinkInfo> List<TMP_LinkInfo> Pointer
    // 040 TempLinkIDs                              000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    public partial class DetailDisplayBase
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
            var value   = new DetailDisplayBase();

            value.NameText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5C48F80 0x20 NameText                    ( 0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DescriptionText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5C48FA0 0x28 DescriptionText             ( 0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CacheBaseIngameSkillDetailKeywordContent  = GetObject<BaseIngameSkillDetailKeywordContent>(new IntPtr(p + 0x030), ReversePrism.DataModels.BaseIngameSkillDetailKeywordContent.FromPointer); // 0270D5C48FC0 0x30 CacheBaseIngameSkillDetailKeywordContent ( 00018673EBE0 ModelClassType BaseIngameSkillDetailKeywordContent BaseIngameSkillDetailKeywordContent BaseIngameSkillDetailKeywordContent Pointer )
            value.TempLinkInfos                             = GetEnumList<TMP_LinkInfo>(new IntPtr(p + 0x038)); // 0270D5C48FE0 0x38 TempLinkInfos               ( 000185D12428 ModelEnumListType List`1<TMP_LinkInfo> List`1<TMP_LinkInfo> List<TMP_LinkInfo> Pointer )
            value.TempLinkIDs                               = GetStringList(new IntPtr(p + 0x040)); // 0270D5C49000 0x40 TempLinkIDs                 ( 000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )

            return value;
        }
    }
}
