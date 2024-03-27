using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Header                                   000186634ED0 ModelClassType MobileScreenHeader MobileScreenHeader MobileScreenHeader Pointer
    // 028 Background                               0001866331A0 ModelClassType MobileScreenBackground MobileScreenBackground MobileScreenBackground Pointer
    // 030 ButtonParent                             0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 038 ButtonPrefab                             000186556660 ModelClassType ChainGroupMemberButton ChainGroupMemberButton ChainGroupMemberButton Pointer
    // 040 ScrollRect                               0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 048 ChainTextColor                           000186568B20 ModelClassType ChainTextColor ChainTextColor ChainTextColor Pointer
    // 050 ScreenFader                              0001866349F0 ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer
    // 058 ResourceLoader                           00018666F230 ModelClassType ResourceLoader ResourceLoader ResourceLoader Pointer
    // 060 ResourceTag                              00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 068 onClickUserButtonSubject                 Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class ChainGroupMemberScreenView
    {
        public MobileScreenHeader?                      Header                                  { get; set; }
        public MobileScreenBackground?                  Background                              { get; set; }
        public Transform?                               ButtonParent                            { get; set; }
        public ChainGroupMemberButton?                  ButtonPrefab                            { get; set; }
        public ScrollRect?                              ScrollRect                              { get; set; }
        public ChainTextColor?                          ChainTextColor                          { get; set; }
        public MobileScreenFader?                       ScreenFader                             { get; set; }
        public ResourceLoader?                          ResourceLoader                          { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static ChainGroupMemberScreenView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainGroupMemberScreenView();

            value.Header                                    = GetObject<MobileScreenHeader>(new IntPtr(p + 0x020), ReversePrism.DataModels.MobileScreenHeader.FromPointer); // 0270DB0E42D0 0x20 Header                      ( 000186634ED0 ModelClassType MobileScreenHeader MobileScreenHeader MobileScreenHeader Pointer )
            value.Background                                = GetObject<MobileScreenBackground>(new IntPtr(p + 0x028), ReversePrism.DataModels.MobileScreenBackground.FromPointer); // 0270DB0E42F0 0x28 Background                  ( 0001866331A0 ModelClassType MobileScreenBackground MobileScreenBackground MobileScreenBackground Pointer )
            value.ButtonParent                              = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 0270DB0E4310 0x30 ButtonParent                ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.ButtonPrefab                              = GetObject<ChainGroupMemberButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.ChainGroupMemberButton.FromPointer); // 0270DB0E4330 0x38 ButtonPrefab                ( 000186556660 ModelClassType ChainGroupMemberButton ChainGroupMemberButton ChainGroupMemberButton Pointer )
            value.ScrollRect                                = GetObject<ScrollRect>(new IntPtr(p + 0x040), ReversePrism.DataModels.ScrollRect.FromPointer); // 0270DB0E4350 0x40 ScrollRect                  ( 0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.ChainTextColor                            = GetObject<ChainTextColor>(new IntPtr(p + 0x048), ReversePrism.DataModels.ChainTextColor.FromPointer); // 0270DB0E4370 0x48 ChainTextColor              ( 000186568B20 ModelClassType ChainTextColor ChainTextColor ChainTextColor Pointer )
            value.ScreenFader                               = GetObject<MobileScreenFader>(new IntPtr(p + 0x050), ReversePrism.DataModels.MobileScreenFader.FromPointer); // 0270DB0E4390 0x50 ScreenFader                 ( 0001866349F0 ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer )
            value.ResourceLoader                            = GetObject<ResourceLoader>(new IntPtr(p + 0x058), ReversePrism.DataModels.ResourceLoader.FromPointer); // 0270DB0E43B0 0x58 ResourceLoader              ( 00018666F230 ModelClassType ResourceLoader ResourceLoader ResourceLoader Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x060), ReversePrism.DataModels.IResourceTag.FromPointer); // 0270DB0E43D0 0x60 ResourceTag                 ( 00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
