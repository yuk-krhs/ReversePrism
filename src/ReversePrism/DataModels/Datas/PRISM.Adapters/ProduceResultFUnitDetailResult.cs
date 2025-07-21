using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstFavoriteMarkId                        ModelPrimitiveType int int int Int32
    // 018 AttachingPotentialLiveSkillList          ModelClassListType IReadOnlyList`1<IAttachingPotentialLiveSkillStatus> IReadOnlyList`1<IAttachingPotentialLiveSkillStatus> List<IAttachingPotentialLiveSkillStatus> Pointer
    // 020 IsDoneTransfer                           ModelPrimitiveType bool bool bool Bool
    // 028 NewUnitName                              ModelPrimitiveType string string string String
    public partial class ProduceResultFUnitDetailResult : DataModel
    {
        public int                                      MstFavoriteMarkId                       { get; set; }
        public List<IAttachingPotentialLiveSkillStatus>? AttachingPotentialLiveSkillList         { get; set; }
        public bool                                     IsDoneTransfer                          { get; set; }
        public string                                   NewUnitName                             { get; set; }

        public static ProduceResultFUnitDetailResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceResultFUnitDetailResult() { Pointer= p0 };

            value.MstFavoriteMarkId                         = GetInt32(new IntPtr(p + 0x010)); // 0x10 MstFavoriteMarkId           ( ModelPrimitiveType int int int Int32 )
            value.AttachingPotentialLiveSkillList           = GetObjectList<IAttachingPotentialLiveSkillStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IAttachingPotentialLiveSkillStatus.FromPointer); // 0x18 AttachingPotentialLiveSkillList ( ModelClassListType IReadOnlyList`1<IAttachingPotentialLiveSkillStatus> IReadOnlyList`1<IAttachingPotentialLiveSkillStatus> List<IAttachingPotentialLiveSkillStatus> Pointer )
            value.IsDoneTransfer                            = GetBool(new IntPtr(p + 0x020)); // 0x20 IsDoneTransfer              ( ModelPrimitiveType bool bool bool Bool )
            value.NewUnitName                               = GetString(new IntPtr(p + 0x028)); // 0x28 NewUnitName                 ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
