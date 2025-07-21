using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IconIdolViews                            ModelClassListType FesUnitIconIdolView[] FesUnitIconIdolView[] List<FesUnitIconIdolView> Pointer
    // 028 CurrentGroup                             ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 030 Ct                                       ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 038 UnitMemberNum                            ModelPrimitiveType int int int Int32
    public partial class FesUnitIdolPositioning : DataModel
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
            var value   = new FesUnitIdolPositioning() { Pointer= p0 };

            value.IconIdolViews                             = GetObjectList<FesUnitIconIdolView>(new IntPtr(p + 0x020), ReversePrism.DataModels.FesUnitIconIdolView.FromPointer); // 0x20 IconIdolViews               ( ModelClassListType FesUnitIconIdolView[] FesUnitIconIdolView[] List<FesUnitIconIdolView> Pointer )
            value.CurrentGroup                              = GetObject<CanvasGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x28 CurrentGroup                ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.Ct                                        = (CancellationToken)GetInt32(new IntPtr(p + 0x030)); // 0x30 Ct                          ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.UnitMemberNum                             = GetInt32(new IntPtr(p + 0x038)); // 0x38 UnitMemberNum               ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
