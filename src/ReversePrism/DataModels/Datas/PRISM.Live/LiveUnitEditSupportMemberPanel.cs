using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Type                                     ModelEnumType LiveIdolParameterType LiveIdolParameterType LiveIdolParameterType Int32
    // 028 IconViews                                ModelClassListType PFIdolIconView[] PFIdolIconView[] List<PFIdolIconView> Pointer
    // 030 EmptyObjects                             ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 038 TotalParameterText                       ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class LiveUnitEditSupportMemberPanel : DataModel
    {
        public LiveIdolParameterType                    Type                                    { get; set; }
        public List<PFIdolIconView>?                    IconViews                               { get; set; }
        public List<GameObject>?                        EmptyObjects                            { get; set; }
        public UITextMeshProUGUI?                       TotalParameterText                      { get; set; }

        public static LiveUnitEditSupportMemberPanel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitEditSupportMemberPanel() { Pointer= p0 };

            value.Type                                      = (LiveIdolParameterType)GetInt32(new IntPtr(p + 0x020)); // 0x20 Type                        ( ModelEnumType LiveIdolParameterType LiveIdolParameterType LiveIdolParameterType Int32 )
            value.IconViews                                 = GetObjectList<PFIdolIconView>(new IntPtr(p + 0x028), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0x28 IconViews                   ( ModelClassListType PFIdolIconView[] PFIdolIconView[] List<PFIdolIconView> Pointer )
            value.EmptyObjects                              = GetObjectList<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 EmptyObjects                ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.TotalParameterText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 TotalParameterText          ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
