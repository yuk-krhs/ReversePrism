using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstFavoriteMarkId                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 AttachingPotentialLiveSkillList          000185CF1948 ModelClassListType IReadOnlyList`1<IAttachingPotentialLiveSkillStatus> IReadOnlyList`1<IAttachingPotentialLiveSkillStatus> List<IAttachingPotentialLiveSkillStatus> Pointer
    // 020 IsDoneTransfer                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 NewUnitName                              000186671910 ModelPrimitiveType string string string String
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

            value.MstFavoriteMarkId                         = GetInt32(new IntPtr(p + 0x010)); // 024665FAB950 0x10 MstFavoriteMarkId           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AttachingPotentialLiveSkillList           = GetObjectList<IAttachingPotentialLiveSkillStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IAttachingPotentialLiveSkillStatus.FromPointer); // 024665FAB970 0x18 AttachingPotentialLiveSkillList ( 000185CF1948 ModelClassListType IReadOnlyList`1<IAttachingPotentialLiveSkillStatus> IReadOnlyList`1<IAttachingPotentialLiveSkillStatus> List<IAttachingPotentialLiveSkillStatus> Pointer )
            value.IsDoneTransfer                            = GetBool(new IntPtr(p + 0x020)); // 024665FAB990 0x20 IsDoneTransfer              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.NewUnitName                               = GetString(new IntPtr(p + 0x028)); // 024665FAB9B0 0x28 NewUnitName                 ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
