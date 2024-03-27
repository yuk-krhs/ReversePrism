using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StateMatProps                            0001865E1260 ModelClassType MaterialPropertyBlock MaterialPropertyBlock MaterialPropertyBlock Pointer
    // 018 DefaultMat                               00018660C4B0 ModelClassType Material Material Material Pointer
    // 020 CurState                                 0001865813B0 ModelEnumType State State State Int32
    // 038 CurPage                                  0001867144C0 ModelClassType Page Page Page Pointer
    // 040 MustApplyMaterial                        000186595960 ModelPrimitiveType bool bool bool Bool
    // 041 MustApplyCommonBlock                     000186595960 ModelPrimitiveType bool bool bool Bool
    // 042 MustApplyStateBlock                      000186595960 ModelPrimitiveType bool bool bool Bool
    // 043 MustApplyStencil                         000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class EvaluationState
    {
        public MaterialPropertyBlock?                   StateMatProps                           { get; set; }
        public Material?                                DefaultMat                              { get; set; }
        public State                                    CurState                                { get; set; }
        public Page?                                    CurPage                                 { get; set; }
        public bool                                     MustApplyMaterial                       { get; set; }
        public bool                                     MustApplyCommonBlock                    { get; set; }
        public bool                                     MustApplyStateBlock                     { get; set; }
        public bool                                     MustApplyStencil                        { get; set; }

        public static EvaluationState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EvaluationState();

            value.StateMatProps                             = GetObject<MaterialPropertyBlock>(new IntPtr(p + 0x010), ReversePrism.DataModels.MaterialPropertyBlock.FromPointer); // 027006860D00 0x10 StateMatProps               ( 0001865E1260 ModelClassType MaterialPropertyBlock MaterialPropertyBlock MaterialPropertyBlock Pointer )
            value.DefaultMat                                = GetObject<Material>(new IntPtr(p + 0x018), ReversePrism.DataModels.Material.FromPointer); // 027006860D20 0x18 DefaultMat                  ( 00018660C4B0 ModelClassType Material Material Material Pointer )
            value.CurState                                  = (State)GetInt32(new IntPtr(p + 0x020)); // 027006860D40 0x20 CurState                    ( 0001865813B0 ModelEnumType State State State Int32 )
            value.CurPage                                   = GetObject<Page>(new IntPtr(p + 0x038), ReversePrism.DataModels.Page.FromPointer); // 027006860D60 0x38 CurPage                     ( 0001867144C0 ModelClassType Page Page Page Pointer )
            value.MustApplyMaterial                         = GetBool(new IntPtr(p + 0x040)); // 027006860D80 0x40 MustApplyMaterial           ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.MustApplyCommonBlock                      = GetBool(new IntPtr(p + 0x041)); // 027006860DA0 0x41 MustApplyCommonBlock        ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.MustApplyStateBlock                       = GetBool(new IntPtr(p + 0x042)); // 027006860DC0 0x42 MustApplyStateBlock         ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.MustApplyStencil                          = GetBool(new IntPtr(p + 0x043)); // 027006860DE0 0x43 MustApplyStencil            ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
