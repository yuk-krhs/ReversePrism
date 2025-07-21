using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 SCharaDetailPopupCaller                  ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer
    // 068 UpdateButton                             ModelClassType UIButton UIButton UIButton Pointer
    // 070 ReloadButtonAnimator                     ModelClassType Animator Animator Animator Pointer
    // 078 FriendContentRoot                        ModelClassType Transform Transform Transform Pointer
    // 080 FriendPrefab                             ModelClassType ProduceFriendContent ProduceFriendContent ProduceFriendContent Pointer
    // 088 ReloadButtonIsEndHash                    ModelPrimitiveType int int int Int32
    // 090 ButtonList                               ModelClassListType List`1<ProduceFriendContent> List`1<ProduceFriendContent> List<ProduceFriendContent> Pointer
    // 098 SelectedSupportModel                     ModelClassType FriendSupportModel FriendSupportModel FriendSupportModel Pointer
    // 0A0 Service                                  ModelClassType ProduceService ProduceService ProduceService Pointer
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

            value.SCharaDetailPopupCaller                   = GetObject<SCharaDetailPopupCaller>(new IntPtr(p + 0x060), ReversePrism.DataModels.SCharaDetailPopupCaller.FromPointer); // 0x60 SCharaDetailPopupCaller     ( ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer )
            value.UpdateButton                              = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 0x68 UpdateButton                ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ReloadButtonAnimator                      = GetObject<Animator>(new IntPtr(p + 0x070), ReversePrism.DataModels.Animator.FromPointer); // 0x70 ReloadButtonAnimator        ( ModelClassType Animator Animator Animator Pointer )
            value.FriendContentRoot                         = GetObject<Transform>(new IntPtr(p + 0x078), ReversePrism.DataModels.Transform.FromPointer); // 0x78 FriendContentRoot           ( ModelClassType Transform Transform Transform Pointer )
            value.FriendPrefab                              = GetObject<ProduceFriendContent>(new IntPtr(p + 0x080), ReversePrism.DataModels.ProduceFriendContent.FromPointer); // 0x80 FriendPrefab                ( ModelClassType ProduceFriendContent ProduceFriendContent ProduceFriendContent Pointer )
            value.ReloadButtonIsEndHash                     = GetInt32(new IntPtr(p + 0x088)); // 0x88 ReloadButtonIsEndHash       ( ModelPrimitiveType int int int Int32 )
            value.ButtonList                                = GetObjectList<ProduceFriendContent>(new IntPtr(p + 0x090), ReversePrism.DataModels.ProduceFriendContent.FromPointer); // 0x90 ButtonList                  ( ModelClassListType List`1<ProduceFriendContent> List`1<ProduceFriendContent> List<ProduceFriendContent> Pointer )
            value.SelectedSupportModel                      = GetObject<FriendSupportModel>(new IntPtr(p + 0x098), ReversePrism.DataModels.FriendSupportModel.FromPointer); // 0x98 SelectedSupportModel        ( ModelClassType FriendSupportModel FriendSupportModel FriendSupportModel Pointer )
            value.Service                                   = GetObject<ProduceService>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ProduceService.FromPointer); // 0xA0 Service                     ( ModelClassType ProduceService ProduceService ProduceService Pointer )

            return value;
        }
    }
}
