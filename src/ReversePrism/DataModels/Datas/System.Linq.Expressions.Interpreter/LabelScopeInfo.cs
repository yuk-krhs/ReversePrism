using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _labels                                  HybridReferenceDictionary`2<LabelTarget, LabelInfo> IL2CPP_TYPE_GENERICINST
    // 018 Kind                                     000186776680 ModelEnumType LabelScopeKind LabelScopeKind LabelScopeKind Int32
    // 020 Parent                                   000186776150 ModelClassType LabelScopeInfo LabelScopeInfo LabelScopeInfo Pointer
    public partial class LabelScopeInfo : DataModel
    {
        public LabelScopeKind                           Kind                                    { get; set; }
        public LabelScopeInfo?                          Parent                                  { get; set; }

        public static LabelScopeInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LabelScopeInfo() { Pointer= p0 };

            value.Kind                                      = (LabelScopeKind)GetInt32(new IntPtr(p + 0x018)); // 02466A050B70 0x18 Kind                        ( 000186776680 ModelEnumType LabelScopeKind LabelScopeKind LabelScopeKind Int32 )
            value.Parent                                    = GetObject<LabelScopeInfo>(new IntPtr(p + 0x020), ReversePrism.DataModels.LabelScopeInfo.FromPointer); // 02466A050B90 0x20 Parent                      ( 000186776150 ModelClassType LabelScopeInfo LabelScopeInfo LabelScopeInfo Pointer )

            return value;
        }
    }
}
