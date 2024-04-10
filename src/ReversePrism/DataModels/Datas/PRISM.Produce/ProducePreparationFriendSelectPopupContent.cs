using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 SCharaDetailPopupCaller                  0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer
    // 068 UpdateButton                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 070 ReloadButtonAnimator                     0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 078 FriendContentRoot                        0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 080 FriendPrefab                             000186541FB0 ModelClassType ProduceFriendContent ProduceFriendContent ProduceFriendContent Pointer
    // 088 ReloadButtonIsEndHash                    0001865F4260 ModelPrimitiveType int int int Int32
    // 090 ButtonList                               000185CFBB78 ModelClassListType List`1<ProduceFriendContent> List`1<ProduceFriendContent> List<ProduceFriendContent> Pointer
    // 098 SelectedSupportModel                     0001865CBED0 ModelClassType FriendSupportModel FriendSupportModel FriendSupportModel Pointer
    // 0A0 Service                                  00018657F920 ModelClassType ProduceService ProduceService ProduceService Pointer
    // 0A8 <OnDecide>k__BackingField                Action`1<FriendSupportModel> IL2CPP_TYPE_GENERICINST
    public partial class ProducePreparationFriendSelectPopupContent : DataModel
    {
        public SCharaDetailPopupCaller?                 SCharaDetailPopupCaller                 { get; set; }
        public UIButton?                                UpdateButton                            { get; set; }
        public Animator?                                ReloadButtonAnimator                    { get; set; }
        public Transform?                               FriendContentRoot                       { get; set; }
        public ProduceFriendContent?                    FriendPrefab                            { get; set; }
        public int                                      ReloadButtonIsEndHash                   { get; set; }
        public List<ProduceFriendContent>?              ButtonList                              { get; set; }
        public FriendSupportModel?                      SelectedSupportModel                    { get; set; }
        public ProduceService?                          Service                                 { get; set; }

        public static ProducePreparationFriendSelectPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducePreparationFriendSelectPopupContent() { Pointer= p0 };

            value.SCharaDetailPopupCaller                   = GetObject<SCharaDetailPopupCaller>(new IntPtr(p + 0x060), ReversePrism.DataModels.SCharaDetailPopupCaller.FromPointer); // 024665A6A728 0x60 SCharaDetailPopupCaller     ( 0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer )
            value.UpdateButton                              = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 024665A6A748 0x68 UpdateButton                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ReloadButtonAnimator                      = GetObject<Animator>(new IntPtr(p + 0x070), ReversePrism.DataModels.Animator.FromPointer); // 024665A6A768 0x70 ReloadButtonAnimator        ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.FriendContentRoot                         = GetObject<Transform>(new IntPtr(p + 0x078), ReversePrism.DataModels.Transform.FromPointer); // 024665A6A788 0x78 FriendContentRoot           ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.FriendPrefab                              = GetObject<ProduceFriendContent>(new IntPtr(p + 0x080), ReversePrism.DataModels.ProduceFriendContent.FromPointer); // 024665A6A7A8 0x80 FriendPrefab                ( 000186541FB0 ModelClassType ProduceFriendContent ProduceFriendContent ProduceFriendContent Pointer )
            value.ReloadButtonIsEndHash                     = GetInt32(new IntPtr(p + 0x088)); // 024665A6A7C8 0x88 ReloadButtonIsEndHash       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ButtonList                                = GetObjectList<ProduceFriendContent>(new IntPtr(p + 0x090), ReversePrism.DataModels.ProduceFriendContent.FromPointer); // 024665A6A7E8 0x90 ButtonList                  ( 000185CFBB78 ModelClassListType List`1<ProduceFriendContent> List`1<ProduceFriendContent> List<ProduceFriendContent> Pointer )
            value.SelectedSupportModel                      = GetObject<FriendSupportModel>(new IntPtr(p + 0x098), ReversePrism.DataModels.FriendSupportModel.FromPointer); // 024665A6A808 0x98 SelectedSupportModel        ( 0001865CBED0 ModelClassType FriendSupportModel FriendSupportModel FriendSupportModel Pointer )
            value.Service                                   = GetObject<ProduceService>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ProduceService.FromPointer); // 024665A6A828 0xA0 Service                     ( 00018657F920 ModelClassType ProduceService ProduceService ProduceService Pointer )

            return value;
        }
    }
}
