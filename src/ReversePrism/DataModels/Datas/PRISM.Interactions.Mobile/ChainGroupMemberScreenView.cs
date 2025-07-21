using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Header                                   ModelClassType MobileScreenHeader MobileScreenHeader MobileScreenHeader Pointer
    // 028 Background                               ModelClassType MobileScreenBackground MobileScreenBackground MobileScreenBackground Pointer
    // 030 ButtonParent                             ModelClassType Transform Transform Transform Pointer
    // 038 ButtonPrefab                             ModelClassType ChainGroupMemberButton ChainGroupMemberButton ChainGroupMemberButton Pointer
    // 040 ScrollRect                               ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 048 ChainTextColor                           ModelClassType ChainTextColor ChainTextColor ChainTextColor Pointer
    // 050 ScreenFader                              ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer
    // 058 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 060 onClickUserButtonSubject                 Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class ChainGroupMemberScreenView : DataModel
    {
        public MobileScreenHeader?                      Header                                  { get; set; }
        public MobileScreenBackground?                  Background                              { get; set; }
        public Transform?                               ButtonParent                            { get; set; }
        public ChainGroupMemberButton?                  ButtonPrefab                            { get; set; }
        public ScrollRect?                              ScrollRect                              { get; set; }
        public ChainTextColor?                          ChainTextColor                          { get; set; }
        public MobileScreenFader?                       ScreenFader                             { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static ChainGroupMemberScreenView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainGroupMemberScreenView() { Pointer= p0 };

            value.Header                                    = GetObject<MobileScreenHeader>(new IntPtr(p + 0x020), ReversePrism.DataModels.MobileScreenHeader.FromPointer); // 0x20 Header                      ( ModelClassType MobileScreenHeader MobileScreenHeader MobileScreenHeader Pointer )
            value.Background                                = GetObject<MobileScreenBackground>(new IntPtr(p + 0x028), ReversePrism.DataModels.MobileScreenBackground.FromPointer); // 0x28 Background                  ( ModelClassType MobileScreenBackground MobileScreenBackground MobileScreenBackground Pointer )
            value.ButtonParent                              = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 0x30 ButtonParent                ( ModelClassType Transform Transform Transform Pointer )
            value.ButtonPrefab                              = GetObject<ChainGroupMemberButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.ChainGroupMemberButton.FromPointer); // 0x38 ButtonPrefab                ( ModelClassType ChainGroupMemberButton ChainGroupMemberButton ChainGroupMemberButton Pointer )
            value.ScrollRect                                = GetObject<ScrollRect>(new IntPtr(p + 0x040), ReversePrism.DataModels.ScrollRect.FromPointer); // 0x40 ScrollRect                  ( ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.ChainTextColor                            = GetObject<ChainTextColor>(new IntPtr(p + 0x048), ReversePrism.DataModels.ChainTextColor.FromPointer); // 0x48 ChainTextColor              ( ModelClassType ChainTextColor ChainTextColor ChainTextColor Pointer )
            value.ScreenFader                               = GetObject<MobileScreenFader>(new IntPtr(p + 0x050), ReversePrism.DataModels.MobileScreenFader.FromPointer); // 0x50 ScreenFader                 ( ModelClassType MobileScreenFader MobileScreenFader MobileScreenFader Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x058), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x58 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
