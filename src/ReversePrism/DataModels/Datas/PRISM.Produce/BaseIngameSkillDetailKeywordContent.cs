using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IngameSkillDetailKeywordContentList      ModelClassListType List`1<IngameSkillDetailKeywordContent> List`1<IngameSkillDetailKeywordContent> List<IngameSkillDetailKeywordContent> Pointer
    // 028 KeywordContentPrefab                     ModelClassType IngameSkillDetailKeywordContent IngameSkillDetailKeywordContent IngameSkillDetailKeywordContent Pointer
    // 030 KeywordContentParent                     ModelClassType Transform Transform Transform Pointer
    public partial class BaseIngameSkillDetailKeywordContent : DataModel
    {
        public List<IngameSkillDetailKeywordContent>?   IngameSkillDetailKeywordContentList     { get; set; }
        public IngameSkillDetailKeywordContent?         KeywordContentPrefab                    { get; set; }
        public Transform?                               KeywordContentParent                    { get; set; }

        public static BaseIngameSkillDetailKeywordContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BaseIngameSkillDetailKeywordContent() { Pointer= p0 };

            value.IngameSkillDetailKeywordContentList       = GetObjectList<IngameSkillDetailKeywordContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.IngameSkillDetailKeywordContent.FromPointer); // 0x20 IngameSkillDetailKeywordContentList ( ModelClassListType List`1<IngameSkillDetailKeywordContent> List`1<IngameSkillDetailKeywordContent> List<IngameSkillDetailKeywordContent> Pointer )
            value.KeywordContentPrefab                      = GetObject<IngameSkillDetailKeywordContent>(new IntPtr(p + 0x028), ReversePrism.DataModels.IngameSkillDetailKeywordContent.FromPointer); // 0x28 KeywordContentPrefab        ( ModelClassType IngameSkillDetailKeywordContent IngameSkillDetailKeywordContent IngameSkillDetailKeywordContent Pointer )
            value.KeywordContentParent                      = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 0x30 KeywordContentParent        ( ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
