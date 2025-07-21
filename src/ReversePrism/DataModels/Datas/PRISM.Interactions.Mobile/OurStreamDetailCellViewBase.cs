using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 DetailButton                             ModelClassType UIButton UIButton UIButton Pointer
    // 028 ThumbnailImage                           ModelClassType UIImage UIImage UIImage Pointer
    // 030 TitleText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 DateLabelText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 DateText                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 StreamerLabelText                        ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 StreamerIconParent                       ModelClassType Transform Transform Transform Pointer
    // 058 StreamerIcon                             ModelClassType UIImage UIImage UIImage Pointer
    // 060 AccountIconAnim                          ModelClassType Animator Animator Animator Pointer
    // 068 AccountIconOnAir                         ModelClassType GameObject GameObject GameObject Pointer
    // 070 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 078 StreamerIconList                         ModelClassListType List`1<UIImage> List`1<UIImage> List<UIImage> Pointer
    // 080 streamerIconPool                         ObjectPool`1<UIImage> IL2CPP_TYPE_GENERICINST
    // 088 onClickStreamerIconSubject               Subject`1<int> IL2CPP_TYPE_GENERICINST
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
        public GameObject?                              AccountIconOnAir                        { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public List<UIImage>?                           StreamerIconList                        { get; set; }

        public static OurStreamDetailCellViewBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamDetailCellViewBase() { Pointer= p0 };

            value.DetailButton                              = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0x20 DetailButton                ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ThumbnailImage                            = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 0x28 ThumbnailImage              ( ModelClassType UIImage UIImage UIImage Pointer )
            value.TitleText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 TitleText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DateLabelText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 DateLabelText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DateText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 DateText                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StreamerLabelText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 StreamerLabelText           ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.StreamerIconParent                        = GetObject<Transform>(new IntPtr(p + 0x050), ReversePrism.DataModels.Transform.FromPointer); // 0x50 StreamerIconParent          ( ModelClassType Transform Transform Transform Pointer )
            value.StreamerIcon                              = GetObject<UIImage>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIImage.FromPointer); // 0x58 StreamerIcon                ( ModelClassType UIImage UIImage UIImage Pointer )
            value.AccountIconAnim                           = GetObject<Animator>(new IntPtr(p + 0x060), ReversePrism.DataModels.Animator.FromPointer); // 0x60 AccountIconAnim             ( ModelClassType Animator Animator Animator Pointer )
            value.AccountIconOnAir                          = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 AccountIconOnAir            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x070), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x70 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.StreamerIconList                          = GetObjectList<UIImage>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIImage.FromPointer); // 0x78 StreamerIconList            ( ModelClassListType List`1<UIImage> List`1<UIImage> List<UIImage> Pointer )

            return value;
        }
    }
}
