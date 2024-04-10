using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ButtonParent                             0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 028 ButtonPrefab                             00018662F4F0 ModelClassType MobileNotificationButton MobileNotificationButton MobileNotificationButton Pointer
    // 030 onClickNotificationSubject               Subject`1<ValueTuple`3<Category, int, int>> IL2CPP_TYPE_GENERICINST
    // 038 isNotificationDisplayed                  ReactiveProperty`1<bool> IL2CPP_TYPE_GENERICINST
    // 040 ResourceLoader                           00018666F230 ModelClassType ResourceLoader ResourceLoader ResourceLoader Pointer
    // 048 ExistingNotificationCounter              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 04C CurrentPlayback                          0001866481C0 ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32
    // 050 CurrentButton                            00018662F4F0 ModelClassType MobileNotificationButton MobileNotificationButton MobileNotificationButton Pointer
    public partial class MobileNotificationView : DataModel
    {
        public Transform?                               ButtonParent                            { get; set; }
        public MobileNotificationButton?                ButtonPrefab                            { get; set; }
        public ResourceLoader?                          ResourceLoader                          { get; set; }
        public int                                      ExistingNotificationCounter             { get; set; }
        public CriAtomExPlayback                        CurrentPlayback                         { get; set; }
        public MobileNotificationButton?                CurrentButton                           { get; set; }

        public static MobileNotificationView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MobileNotificationView() { Pointer= p0 };

            value.ButtonParent                              = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0245A4F63948 0x20 ButtonParent                ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.ButtonPrefab                              = GetObject<MobileNotificationButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.MobileNotificationButton.FromPointer); // 0245A4F63968 0x28 ButtonPrefab                ( 00018662F4F0 ModelClassType MobileNotificationButton MobileNotificationButton MobileNotificationButton Pointer )
            value.ResourceLoader                            = GetObject<ResourceLoader>(new IntPtr(p + 0x040), ReversePrism.DataModels.ResourceLoader.FromPointer); // 0245A4F639C8 0x40 ResourceLoader              ( 00018666F230 ModelClassType ResourceLoader ResourceLoader ResourceLoader Pointer )
            value.ExistingNotificationCounter               = GetInt32(new IntPtr(p + 0x048)); // 0245A4F639E8 0x48 ExistingNotificationCounter ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentPlayback                           = (CriAtomExPlayback)GetInt32(new IntPtr(p + 0x04C)); // 0245A4F63A08 0x4C CurrentPlayback             ( 0001866481C0 ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32 )
            value.CurrentButton                             = GetObject<MobileNotificationButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.MobileNotificationButton.FromPointer); // 0245A4F63A28 0x50 CurrentButton               ( 00018662F4F0 ModelClassType MobileNotificationButton MobileNotificationButton MobileNotificationButton Pointer )

            return value;
        }
    }
}
