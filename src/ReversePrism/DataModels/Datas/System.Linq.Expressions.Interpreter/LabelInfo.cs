using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Node                                     ModelClassType LabelTarget LabelTarget LabelTarget Pointer
    // 018 Label                                    ModelClassType BranchLabel BranchLabel BranchLabel Pointer
    // 020 _definitions                             <object> IL2CPP_TYPE_OBJECT
    // 028 References                               ModelClassListType List`1<LabelScopeInfo> List`1<LabelScopeInfo> List<LabelScopeInfo> Pointer
    // 030 AcrossBlockJump                          ModelPrimitiveType bool bool bool Bool
    public partial class LabelInfo : DataModel
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
            var value   = new LabelInfo() { Pointer= p0 };

            value.Node                                      = GetObject<LabelTarget>(new IntPtr(p + 0x010), ReversePrism.DataModels.LabelTarget.FromPointer); // 0x10 Node                        ( ModelClassType LabelTarget LabelTarget LabelTarget Pointer )
            value.Label                                     = GetObject<BranchLabel>(new IntPtr(p + 0x018), ReversePrism.DataModels.BranchLabel.FromPointer); // 0x18 Label                       ( ModelClassType BranchLabel BranchLabel BranchLabel Pointer )
            value.References                                = GetObjectList<LabelScopeInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.LabelScopeInfo.FromPointer); // 0x28 References                  ( ModelClassListType List`1<LabelScopeInfo> List`1<LabelScopeInfo> List<LabelScopeInfo> Pointer )
            value.AcrossBlockJump                           = GetBool(new IntPtr(p + 0x030)); // 0x30 AcrossBlockJump             ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
