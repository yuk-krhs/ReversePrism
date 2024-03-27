using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IconIdolViews                            000185B7EE60 ModelClassListType FesUnitIconIdolView[] FesUnitIconIdolView[] List<FesUnitIconIdolView> Pointer
    // 028 CurrentGroup                             000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 030 Ct                                       00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 038 UnitMemberNum                            0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class FesUnitIdolPositioning
    {
        public List<FesUnitIconIdolView>?               IconIdolViews                           { get; set; }
        public CanvasGroup?                             CurrentGroup                            { get; set; }
        public CancellationToken                        Ct                                      { get; set; }
        public int                                      UnitMemberNum                           { get; set; }

        public static FesUnitIdolPositioning? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FesUnitIdolPositioning();

            value.IconIdolViews                             = GetObjectList<FesUnitIconIdolView>(new IntPtr(p + 0x020), ReversePrism.DataModels.FesUnitIconIdolView.FromPointer); // 027005B22548 0x20 IconIdolViews               ( 000185B7EE60 ModelClassListType FesUnitIconIdolView[] FesUnitIconIdolView[] List<FesUnitIconIdolView> Pointer )
            value.CurrentGroup                              = GetObject<CanvasGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.CanvasGroup.FromPointer); // 027005B22568 0x28 CurrentGroup                ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.Ct                                        = (CancellationToken)GetInt32(new IntPtr(p + 0x030)); // 027005B22588 0x30 Ct                          ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.UnitMemberNum                             = GetInt32(new IntPtr(p + 0x038)); // 027005B225A8 0x38 UnitMemberNum               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
