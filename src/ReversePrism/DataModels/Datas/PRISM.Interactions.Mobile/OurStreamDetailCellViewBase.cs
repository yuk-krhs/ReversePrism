using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 DetailButton                             0001866E11C0 ModelClassType UIButton UIButton UIButton Pointer
    // 028 ThumbnailImage                           0001866EB060 ModelClassType UIImage UIImage UIImage Pointer
    // 030 TitleText                                0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 DateLabelText                            0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 DateText                                 0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 StreamerLabelText                        0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 StreamerIconParent                       0001866AA3C0 ModelClassType Transform Transform Transform Pointer
    // 058 StreamerIcon                             0001866EB060 ModelClassType UIImage UIImage UIImage Pointer
    // 060 AccountIconAnim                          0001866B8FF0 ModelClassType Animator Animator Animator Pointer
    // 068 ResourceLoader                           00018666F460 ModelClassType ResourceLoader ResourceLoader ResourceLoader Pointer
    // 070 ResourceTag                              00018661C4E0 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 078 StreamerIconList                         000185D17EF8 ModelClassListType List`1<UIImage> List`1<UIImage> List<UIImage> Pointer
    // 080 streamerIconPool                         ObjectPool`1<UIImage> IL2CPP_TYPE_GENERICINST
    public partial class OurStreamDetailCellViewBase : DataModel
    {
        public UIButton?                                DetailButton                            { get; set; }
        public UIImage?                                 ThumbnailImage                          { get; set; }
        public UITextMeshProUGUI?                       TitleText                               { get; set; }
        public UITextMeshProUGUI?                       DateLabelText                           { get; set; }
        public UITextMeshProUGUI?                       DateText                                { get; set; }
        public UITextMeshProUGUI?                       StreamerLabelText                       { get; set; }
        public Transform?                               StreamerIconParent                      { get; set; }
        public UIImage?                                 StreamerIcon                            { get; set; }
        public Animator?                                AccountIconAnim                         { get; set; }
        public ResourceLoader?                          ResourceLoader                          { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }
        public List<UIImage>?                           StreamerIconList                        { get; set; }

        public static OurStreamDetailCellViewBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamDetailCellViewBase() { Pointer= p0 };

            value.DetailButton                              = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 02466B196B28 0x20 DetailButton                ( 0001866E11C0 ModelClassType UIButton UIButton UIButton Pointer )
            value.ThumbnailImage                            = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 02466B196B48 0x28 ThumbnailImage              ( 0001866EB060 ModelClassType UIImage UIImage UIImage Pointer )
            value.TitleText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B196B68 0x30 TitleText                   ( 0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DateLabelText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B196B88 0x38 DateLabelText               ( 0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DateText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B196BA8 0x40 DateText                    ( 0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StreamerLabelText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B196BC8 0x48 StreamerLabelText           ( 0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StreamerIconParent                        = GetObject<Transform>(new IntPtr(p + 0x050), ReversePrism.DataModels.Transform.FromPointer); // 02466B196BE8 0x50 StreamerIconParent          ( 0001866AA3C0 ModelClassType Transform Transform Transform Pointer )
            value.StreamerIcon                              = GetObject<UIImage>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIImage.FromPointer); // 02466B196C08 0x58 StreamerIcon                ( 0001866EB060 ModelClassType UIImage UIImage UIImage Pointer )
            value.AccountIconAnim                           = GetObject<Animator>(new IntPtr(p + 0x060), ReversePrism.DataModels.Animator.FromPointer); // 02466B196C28 0x60 AccountIconAnim             ( 0001866B8FF0 ModelClassType Animator Animator Animator Pointer )
            value.ResourceLoader                            = GetObject<ResourceLoader>(new IntPtr(p + 0x068), ReversePrism.DataModels.ResourceLoader.FromPointer); // 02466B196C48 0x68 ResourceLoader              ( 00018666F460 ModelClassType ResourceLoader ResourceLoader ResourceLoader Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x070), ReversePrism.DataModels.IResourceTag.FromPointer); // 02466B196C68 0x70 ResourceTag                 ( 00018661C4E0 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )
            value.StreamerIconList                          = GetObjectList<UIImage>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIImage.FromPointer); // 02466B196C88 0x78 StreamerIconList            ( 000185D17EF8 ModelClassListType List`1<UIImage> List`1<UIImage> List<UIImage> Pointer )

            return value;
        }
    }
}
