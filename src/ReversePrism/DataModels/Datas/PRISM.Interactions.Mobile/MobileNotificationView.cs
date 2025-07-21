using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ButtonParent                             ModelClassType Transform Transform Transform Pointer
    // 028 ButtonPrefab                             ModelClassType MobileNotificationButton MobileNotificationButton MobileNotificationButton Pointer
    // 030 onClickNotificationSubject               Subject`1<ValueTuple`3<Category, int, int>> IL2CPP_TYPE_GENERICINST
    // 038 isNotificationDisplayed                  ReactiveProperty`1<bool> IL2CPP_TYPE_GENERICINST
    // 040 ExistingNotificationCounter              ModelPrimitiveType int int int Int32
    // 044 CurrentPlayback                          ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32
    // 048 CurrentButton                            ModelClassType MobileNotificationButton MobileNotificationButton MobileNotificationButton Pointer
    public partial class MobileNotificationView : DataModel
    {
        public Transform?                               ButtonParent                            { get; set; }
        public MobileNotificationButton?                ButtonPrefab                            { get; set; }
        public int                                      ExistingNotificationCounter             { get; set; }
        public CriAtomExPlayback                        CurrentPlayback                         { get; set; }
        public MobileNotificationButton?                CurrentButton                           { get; set; }

        public static MobileNotificationView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MobileNotificationView() { Pointer= p0 };

            value.ButtonParent                              = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0x20 ButtonParent                ( ModelClassType Transform Transform Transform Pointer )
            value.ButtonPrefab                              = GetObject<MobileNotificationButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.MobileNotificationButton.FromPointer); // 0x28 ButtonPrefab                ( ModelClassType MobileNotificationButton MobileNotificationButton MobileNotificationButton Pointer )
            value.ExistingNotificationCounter               = GetInt32(new IntPtr(p + 0x040)); // 0x40 ExistingNotificationCounter ( ModelPrimitiveType int int int Int32 )
            value.CurrentPlayback                           = (CriAtomExPlayback)GetInt32(new IntPtr(p + 0x044)); // 0x44 CurrentPlayback             ( ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32 )
            value.CurrentButton                             = GetObject<MobileNotificationButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.MobileNotificationButton.FromPointer); // 0x48 CurrentButton               ( ModelClassType MobileNotificationButton MobileNotificationButton MobileNotificationButton Pointer )

            return value;
        }
    }
}
