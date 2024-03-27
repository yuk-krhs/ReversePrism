using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Node                                     000186777830 ModelClassType LabelTarget LabelTarget LabelTarget Pointer
    // 018 Label                                    0001867710C0 ModelClassType BranchLabel BranchLabel BranchLabel Pointer
    // 020 _definitions                             <object> IL2CPP_TYPE_OBJECT
    // 028 References                               000185CEF8E8 ModelClassListType List`1<LabelScopeInfo> List`1<LabelScopeInfo> List<LabelScopeInfo> Pointer
    // 030 AcrossBlockJump                          000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class LabelInfo
    {
        public LabelTarget?                             Node                                    { get; set; }
        public BranchLabel?                             Label                                   { get; set; }
        public List<LabelScopeInfo>?                    References                              { get; set; }
        public bool                                     AcrossBlockJump                         { get; set; }

        public static LabelInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LabelInfo();

            value.Node                                      = GetObject<LabelTarget>(new IntPtr(p + 0x010), ReversePrism.DataModels.LabelTarget.FromPointer); // 0270D9FDD0A8 0x10 Node                        ( 000186777830 ModelClassType LabelTarget LabelTarget LabelTarget Pointer )
            value.Label                                     = GetObject<BranchLabel>(new IntPtr(p + 0x018), ReversePrism.DataModels.BranchLabel.FromPointer); // 0270D9FDD0C8 0x18 Label                       ( 0001867710C0 ModelClassType BranchLabel BranchLabel BranchLabel Pointer )
            value.References                                = GetObjectList<LabelScopeInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.LabelScopeInfo.FromPointer); // 0270D9FDD108 0x28 References                  ( 000185CEF8E8 ModelClassListType List`1<LabelScopeInfo> List`1<LabelScopeInfo> List<LabelScopeInfo> Pointer )
            value.AcrossBlockJump                           = GetBool(new IntPtr(p + 0x030)); // 0270D9FDD128 0x30 AcrossBlockJump             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
